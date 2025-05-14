using Microsoft.AspNetCore.Mvc;

namespace WebAppMvc6.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(string producto)
        {
            var carrito = new WebAppMvc6.Models.Carrito()
            {
                Id = 1,
                Producto = producto
            };

            //var demo = producto;

            //escribir archivo de texto

            return View(carrito);
        }
    }
}
