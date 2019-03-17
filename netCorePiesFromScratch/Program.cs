using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using netCorePiesFromScratch.Models;
using System;

namespace netCorePiesFromScratch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

//            var host = CreateWebHostBuilder(args).Build();
//
//            using (var scope = host.Services.CreateScope())
//            {
//                var services = scope.ServiceProvider;
//                try
//                {
//                    var context = services.GetRequiredService<AppDbContext>();
//                    DbInitializer.Seed(context);
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e);
//                    // logging possibility....
//                }
//            }
                
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
