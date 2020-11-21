using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PaymentService
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		struct MyPair
		{
			public int Id { get; set; }
			public string MethodName { get; set; }
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
			    .ConfigureServices(services =>
			    {
				    services.AddSingleton<HttpClient>();
			    })
			    .ConfigureWebHostDefaults(webBuilder =>
			    {
				    webBuilder.UseStartup<Startup>();
			    });
	}
}
