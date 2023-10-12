using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Starwars.Apps.WebAppMvc.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Buscar(string nombre)
        {
            var htmlEncoder = HtmlEncoder.Create();
            
            var input = htmlEncoder.Encode(nombre);

            return Content($"<html><body><h1>{input}</h1></body></html>", "text/html");

        }
    }
}
