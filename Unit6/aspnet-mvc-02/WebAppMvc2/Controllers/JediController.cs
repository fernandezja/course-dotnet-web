using Microsoft.AspNetCore.Mvc;

namespace WebAppMvc2.Controllers
{
    public class JediController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Razor
        }

        [Route("jedi/jedi-{id:int}.html")]
        [Route("jedi/jedi_{id}.html")]
        public IActionResult Detail(int? id)
        {
            return View("DetailInternal"); //Razor
        }

        public IActionResult Demo()
        {
            return Content("Jedi Demo");
        }
    }
}
