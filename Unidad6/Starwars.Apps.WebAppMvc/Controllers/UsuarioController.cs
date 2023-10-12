using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Starwars.Apps.WebAppMvc.Controllers
{
    public class UsuarioController : Controller
    {

        public IActionResult Buscar(string name) {

            var htmlEncoder = HtmlEncoder.Create();

            if (string.IsNullOrEmpty(name))
            {
                name = "s/d";
            }

            var input = htmlEncoder.Encode(name);

            //return Content(input);
            return Content($"<html><body><h1>{input}</h1></body></html>", "text/html");
        }
    }
}
