
using Starwars.Core.Business;
using Starwars.Core.DataADONet;
using Starwars.Core.Entities;

namespace Starwars.Apps.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //var starwarsConnectionString = builder.Configuration.GetSection("ConnectionStrings:StarwarsConnectionString");
            var starwarsConnectionString = builder.Configuration.GetConnectionString("StarwarsConnectionString");

            var starwarsConfig = new StarwarsConfig()
            {
                StarwarsConnectionString = starwarsConnectionString
            };

            //builder.Services.AddSingleton
            builder.Services.AddSingleton<StarwarsConfig>(provider => {
                return starwarsConfig;
            });

            builder.Services.AddScoped<JediRepository>();
            builder.Services.AddScoped<JediBusiness>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
