using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Lab3Register.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;

namespace Lab3Register.Controllers
{
    public class HomeController : Controller
    {
        public IConfiguration AppConfiguration { get; set; }

        public HomeController(IConfiguration configuration)
        {
            AppConfiguration = configuration;
        }

        [HttpPost]
        public ActionResult RemoveService(HomeModel model, string serviceName)
        {
            //model.methods.RemoveAt(serviceIndex);


            string connectionString = AppConfiguration.GetConnectionString("mySqlDb");


            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string deleteMethodsQuery = $"DELETE FROM Methods WHERE ServiceId = '{serviceName}'";

            MySqlCommand command1 = new MySqlCommand(deleteMethodsQuery, connection);

            command1.ExecuteNonQuery();

            string deleteServiceQuery = $"DELETE FROM Service WHERE id = '{serviceName}'";

            MySqlCommand command2 = new MySqlCommand(deleteServiceQuery, connection);

            command2.ExecuteNonQuery();

            connection.Close();

            return Index();
        }

        [HttpPost]
        public ActionResult RemoveServiceMethod(HomeModel model,  string methodName)
        {
            //model.methods[serviceIndex].Value.RemoveAt(methodIndex);

            string connectionString = AppConfiguration.GetConnectionString("mySqlDb");

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string deleteMethodsQuery = $"DELETE FROM Methods WHERE MethodName = '{methodName}'";

            MySqlCommand command1 = new MySqlCommand(deleteMethodsQuery, connection);

            command1.ExecuteNonQuery();

            connection.Close();

            return Index();
        }

        [HttpPost]
        public ActionResult AddService(HomeModel model, string newServiceName)
        {
            //model.methods.Add(new KeyValuePair<string, List<string>>("NewService",new List<string>(){"TestMethod"}));

            if (newServiceName.Equals(""))
            {
                return Index();
            }


            string connectionString = AppConfiguration.GetConnectionString("mySqlDb");

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string insertServiceQuery = $"INSERT Service(id) VALUES ('{newServiceName}')";

            MySqlCommand command = new MySqlCommand(insertServiceQuery, connection);

            try
            {
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to add new service");
            }
            connection.Close();

            return Index();
        }

        [HttpPost]
        public ActionResult AddServiceMethod( string serviceName)
        {
            //model.methods[serviceIndex].Value.Add("TestMethod");

            string serviceMethodName = Request.Form[serviceName + " NewMethod"];

            if (serviceMethodName.Equals(""))
            {
                return Index();
            }

            try
            {
                string connectionString = AppConfiguration.GetConnectionString("mySqlDb");

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                string insertServiceQuery = $"INSERT INTO Methods (ServiceId,MethodName) VALUES ( '{serviceName}','{serviceMethodName}')";

                MySqlCommand command = new MySqlCommand(insertServiceQuery, connection);

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                //Pofig
            }

            return Index();
        }


        public ActionResult Index()
        {
            string connectionString = AppConfiguration.GetConnectionString("mySqlDb");


            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string selectQuery = "SELECT Service.id, MethodName, Methods.ServiceId as MethodsServiceName FROM Methods RIGHT JOIN Service ON ( Methods.ServiceId = Service.Id) ORDER BY Service.id";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();

            HomeModel model = new HomeModel();

            while (reader.Read())
            {
                string serviceName = reader.GetString(0);

                string methodName = "";

                if (!reader.IsDBNull(1))
                {
                    methodName = reader.GetString(1);
                } 

                if (!model.methods.Exists(pair => pair.Key.Equals(serviceName)))
                {
                    model.methods.Add(new KeyValuePair<string, List<string>>(serviceName, new List<string>()));
                }

                if (!methodName.Equals(""))
                {
                    model.methods.Find(pair => pair.Key.Equals(serviceName)).Value.Add(methodName);
                }

            }

            ////TODO: remove this add.
            //if (model.methods.Count == 0)
            //{
            //    model.methods.Add(new KeyValuePair<string, List<string>>("IvanService", new List<string>() {"drink beer", "drink svoyak", "Do laba Davidovskoy"}));
            //    model.methods.Add(new KeyValuePair<string, List<string>>("RomaService", new List<string>() {"drink zemlyak", "Do sleep"}));

            //}

            connection.Close();

            return View("Index", model);
        }
    }
}