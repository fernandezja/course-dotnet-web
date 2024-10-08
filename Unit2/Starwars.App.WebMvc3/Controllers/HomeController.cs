using Microsoft.AspNetCore.Mvc;
using Starwars.App.WebMvc3.Models;
using Starwars.Core.Negocio;
using System.Diagnostics;

namespace Starwars.App.WebMvc3.Controllers
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
            var jediNegocio = new JediNegocio();
            var jedis = jediNegocio.GetAll();
            return View(jedis);
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
