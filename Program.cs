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
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            // var host = new HostBuilder().ConfigureAppConfiguration((hostContext, builder) =>
            // {
            //     // Add other providers for JSON, etc.

            //     if (hostContext.HostingEnvironment.IsDevelopment())
            //     {
            //         builder.AddUserSecrets<Program>();
            //     }
            // }).Build();
        
            // host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
