using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace dream_of_electric_sheep
{
    public class Program
    {
        public static IConfigurationRoot Configuration;
        const string SecretName= "COIN_MARKET_CAP_API_KEY";
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            /*var host = new HostBuilder().ConfigureAppConfiguration((hostContext, builder) =>
            {
                // Add other providers for JSON, etc.
                CreateHostBuilder(args).Build().Run();

                if (hostContext.HostingEnvironment.IsDevelopment())
                {
                    builder.AddUserSecrets<Program>();
                }
            }).Build();
        
            host.Run();*/
            BootstrapConfiguration();
            
            Console.WriteLine($"The Secret key is {Configuration[SecretName]}");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void BootstrapConfiguration()
        {
            string env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (string.IsNullOrWhiteSpace(env))
            {
                env = "Development";
            }

            var builder = new ConfigurationBuilder();

            if (env == "Development")
            {
                builder.AddUserSecrets<Program>();
            }

            Configuration = builder.Build();
        }
    }
}
