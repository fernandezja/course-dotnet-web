using Microsoft.Extensions.DependencyInjection;
using Starwars.Core.Business;
using Starwars.Core.DataADONet;
using Starwars.Core.Entities;

namespace Starwars.Apps.WebAppMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            var starwarsConfig = new StarwarsConfig() {
                StarwarsConnectionString = "Persist Security Info=True;Initial Catalog=Starwars;Data Source=.; Integrated Security=True;TrustServerCertificate=True;"
            };

            //builder.Services.AddSingleton
            builder.Services.AddSingleton<StarwarsConfig>(provider => { 
                return starwarsConfig;
            });

            builder.Services.AddScoped<JediRepository>();
            builder.Services.AddScoped<JediBusiness>();

            //builder.Services.AddTransient

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
