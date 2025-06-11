var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

var environment = app.Environment.EnvironmentName;

if (string.IsNullOrEmpty(environment))
{
    environment = "Production";
}

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddJsonFile($"appsettings.{environment}.json", optional: true)
    .AddEnvironmentVariables()
    .AddUserSecrets<Program>()
    .Build();

var clientId = config.GetSection("Course:ClientId").Value;


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


//app.MapControllerRoute(
//    name: "jedi-listado",
//    pattern: "jedi/listado",
//    new { controller = "Jedi", action = "Index" },
//    constraints:
//    );


app.MapGet("/demo0", () =>  "NET Web DEmo0");

app.MapControllerRoute(
    name: "demo2",
    pattern: "esta-pagina-es-demo.html",
    defaults: new { controller = "Demo", action = "Index" });

app.MapControllerRoute(
    name: "demo3",
    pattern: "carpeta1/demo/{*demo}",
    defaults: new { controller = "Demo", action = "Index" });



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
