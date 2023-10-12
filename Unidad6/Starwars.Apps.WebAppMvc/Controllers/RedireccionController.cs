using Microsoft.AspNetCore.Mvc;
using Starwars.Apps.WebAppMvc.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace Starwars.Apps.WebAppMvc.Controllers
{
    public class RedireccionController : Controller
    {
        public IActionResult Index(string id)
        {
            return RedirectToAction(controllerName: "Usuario",
                                    actionName: "Buscar",
                                    routeValues: new { nombre = id });

        }

    }
}
