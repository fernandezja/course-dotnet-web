using Microsoft.AspNetCore.Mvc;
using Starwars.Apps.WebAppMvc.Models;
using System.Diagnostics;

namespace Starwars.Apps.WebAppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            

            //ExpandoObject
            ViewBag.Nombre = "Luke";
            ViewBag.Apellido = "Starwars";

            ViewData["Nombre"] = "Yoda";

            //ViewData["Nombre 1"] = "Yoda";

            var demo = ViewBag.Nombre;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
