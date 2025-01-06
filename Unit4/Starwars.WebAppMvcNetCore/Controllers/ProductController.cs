using Microsoft.AspNetCore.Mvc;
using Starwars.Core.Negocio;

namespace Starwars.WebAppMvcNetCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var starwarsNegocio = new StarwarsNegocio();
            
            var products = starwarsNegocio.GetAll();

            return View(products);
        }
    }
}
