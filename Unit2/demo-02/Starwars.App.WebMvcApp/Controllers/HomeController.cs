using Microsoft.AspNetCore.Mvc;
using Starwars.App.WebMvcApp.Models;
using System.Diagnostics;

namespace Starwars.App.WebMvcApp.Controllers
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
            var jediBusiness = new Starwars.Core.Business.JediBusiness();
            var jedi = jediBusiness.GetJedi(10);

            return View(jedi);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
