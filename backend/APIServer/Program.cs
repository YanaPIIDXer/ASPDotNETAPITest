using APIServer.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            createAdmin(host).Wait();
            host.Run();
        }

        private static async Task createAdmin(IHost host)
		{
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var userManager = services.GetService<UserManager<User>>();
                var adminUser = await userManager.FindByNameAsync("Admin");
                if (adminUser == null)
                {
                    var roleManager = services.GetService<RoleManager<IdentityRole>>();
                    await roleManager.CreateAsync(new IdentityRole("Admin"));
                    adminUser = new User() { UserName = "Admin" };
                    await userManager.CreateAsync(adminUser, "password");
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseUrls("http://*:3000")
                        .UseStartup<Startup>();
                });
    }
}
