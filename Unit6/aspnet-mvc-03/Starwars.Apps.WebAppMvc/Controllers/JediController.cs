using Microsoft.AspNetCore.Mvc;
using Starwars.Apps.WebAppMvc.Models;
using Starwars.Core.Entities;

namespace Starwars.Apps.WebAppMvc.Controllers
{
    public class JediController: Controller
    {

        public JediController()
        {
            
        }

        public IActionResult Index()
        {
            //return Content("<html><body>Hola <strong>Jedi</strong></body></html>", 
            //                "text/html");

            return View();
        }


        public IActionResult Details(int id)
        {
            var jedi = new Jedi { 
                JediId = id, 
                Name = $"Obi-Wan Kenobi [{id}]" 
            };

            var model = new JediPageViewModel();
            model.Jedi = jedi;
            model.Title = "Jedi Details";

            //ViewBag["Message"] = "Hello from the controller";
            ViewBag.Message = "Hello from the controller";
            //ExpandoObject

            return View(model);
        }

        public IActionResult DetailsCustom1(int jediId, string name)
        {
            var jedi = new Jedi
            {
                JediId = jediId,
                Name = $"Obi-Wan Kenobi [{jediId}]"
            };

            var model = new JediPageViewModel();
            model.Jedi = jedi;
            model.Title = "Jedi Details";

            //ViewBag["Message"] = "Hello from the controller";
            ViewBag.Message = "Hello from the controller";
            //ExpandoObject

            return View("Details", model);
        }


        [Route("j-custom-{jediId:int}-demo")]
        [Route("j_{jediId:int}.html")]
        public IActionResult DetailsCustom2(int jediId, string name)
        {
            var jedi = new Jedi
            {
                JediId = jediId,
                Name = $"Obi-Wan Kenobi [{jediId}]"
            };

            var model = new JediPageViewModel();
            model.Jedi = jedi;
            model.Title = "Jedi Details";

            //ViewBag["Message"] = "Hello from the controller";
            ViewBag.Message = "Hello from the controller";
            //ExpandoObject

            return View("Details", model);
        }
    }
}
