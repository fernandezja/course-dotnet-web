using Microsoft.AspNetCore.Mvc;
using Starwars.Core.Entities;

namespace WebApplication4.Controllers
{
    //[Route("[controller]")]
    public class JediController : Controller
    {
        [Route("jedi/listado-completo")]
        [Route("jedi/lista")]
        [Route("jedi.html")]
        public IActionResult Index()
        {
            //return Content("<html><body><h1>Hello Jedi!</h1></body></html>", 
            //                contentType: "text/html");

            return View();

        }


        [Route("jedi/Obi-Wan-Kenobi-{id:int}.html")]
        [Route("jedi-{id:int}.html")]
        public IActionResult Details(int id)
        {
            var jedi = new Jedi()
            {
                JediId = id,
                Name = "Obi-Wan Kenobi"
                //Rank = "Jedi Master",
                //LightsaberColor = "Blue"
            };
            return View(viewName:"JediDetails", 
                        model: jedi);

        }
    }
}
