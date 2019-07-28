using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Demo.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DemoDotNetCoreWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host =  CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                
                try
                {
                    var context = services.GetRequiredService<ApplicationDBContext>();
                    context.Database.Migrate();
                    //SeedData.Initialize(services);
                }catch(Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message);
                }
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                // Call other providers here and call AddCommandLine last.
                config.AddCommandLine(args);
            })
            .UseStartup<Startup>();
    }
}
