using Starwars.Core.Business;
using Starwars.Core.Entities;

var builder = WebApplication.CreateBuilder(args);


//Init: Config
var configuration = new ConfigurationBuilder()
                        .AddJsonFile($"appSettings.json");

var config = configuration.Build();

var title1 = config["Title"];
var title2 = config.GetSection("Title");

var connectionString1 = config.GetSection("ConnectionStrings:StarwarsConnectionString");


var connectionString = config.GetConnectionString("StarwarsConnectionString");

var starwarsConfig = new StarwarsConfig();
starwarsConfig.StarwarsConnectionString = connectionString;



// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton(starwarsConfig);
builder.Services.AddScoped<JediBusiness>();

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
