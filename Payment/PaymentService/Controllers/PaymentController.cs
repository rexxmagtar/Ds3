using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace PaymentService.Controllers
{
	[ApiController]
	public class PaymentController : ControllerBase
	{
		private readonly HttpClient _client;
		private readonly string _connectionString;
		private readonly string _registerApiURL;

		public PaymentController(IConfiguration configuration, HttpClient client)
		{
			_connectionString = configuration.GetConnectionString("TokenDatabase");
			_registerApiURL = configuration.GetValue<string>("RegisterApiURL");
			_client = client;
		}

		// Пример запроса: https://localhost:5001/Pay?service=TestService&method=TestMethod&token=TestToken
		// Пример ответа: {"Result":true,"Message":"OK"}
		[HttpGet("Pay/")]
		public async Task<string> PayAsync(string service, string method, string token)
		{
			bool result = true;
			string message = "OK";

			try
			{
				var registerRequest = new HttpRequestMessage(HttpMethod.Get, $"{_registerApiURL}/getMethods/{service}");

				var registerReply = await _client.SendAsync(registerRequest);
				Console.WriteLine($"{_registerApiURL}/getMethods/{service}");
				{
					throw new Exception("Wrong service");
				}

				string registerReplyContent = await registerReply.Content.ReadAsStringAsync();

				var methodPairs = JsonSerializer.Deserialize<MethodIdNamePair[]>(registerReplyContent, new JsonSerializerOptions {PropertyNameCaseInsensitive = true});

				var pair = methodPairs.FirstOrDefault(x => x.MethodName == method);

				if (pair == null)
				{
					throw new Exception("Wrong method");
				}

				await using (var connection = new MySqlConnection(_connectionString))
				{
					await connection.OpenAsync();

					var commandUpdate = new MySqlCommand(SQLHelper.UpdateToken, connection);
					commandUpdate.Parameters.AddWithValue("@Id", token);
					commandUpdate.Parameters.AddWithValue("@MethodId", pair.Id);

					await commandUpdate.ExecuteNonQueryAsync();

					await connection.CloseAsync();
				}
			}
			catch (Exception ex)
			{
				result = false;
				message = ex.Message;
			}

			string reply = JsonSerializer.Serialize(new {Result = result, Message = message});

			return reply;
		}
		
		[HttpGet("IsPaid/")]
		public async Task<string> IsPaidAsync(string service, string method, string token)
		{
			bool result = true;
			string message = "The token is paid for the method";

			try
			{
				await using (var connection = new MySqlConnection(_connectionString))
				{
					await connection.OpenAsync();

					var commandGet = new MySqlCommand(SQLHelper.GetMethodId, connection);
					commandGet.Parameters.AddWithValue("@Id", token);

					var methodId = await commandGet.ExecuteScalarAsync();

					if (methodId == null)
					{
						throw new Exception("The token is not paid at all");
					}
					
					var commandGetInfo = new MySqlCommand(SQLHelper.GetMethodInfo, connection);
					commandGetInfo.Parameters.AddWithValue("@Id", methodId);

					var reader = await commandGetInfo.ExecuteReaderAsync();
					
					await reader.ReadAsync();
					
					string serviceId = reader.GetString(0);
					string methodName = reader.GetString(1);

					if (serviceId != service || methodName != method)
					{
						throw new Exception("The token is used for another method");
					}

					await connection.CloseAsync();
				}
			}
			catch (Exception ex)
			{
				result = false;
				message = ex.Message;
			}

			string reply = JsonSerializer.Serialize(new {Result = result, Message = message});

			return reply;
		}

		private class MethodIdNamePair
		{
			public int Id { get; set; }
			public string MethodName { get; set; }
		}
	}
}
