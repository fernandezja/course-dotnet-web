using Microsoft.AspNetCore.Mvc;
using Starwars.Core.Business;
using Starwars.Core.Entities;

namespace Starwars.Apps.WebAppMvc.Controllers
{
    public class JediController : Controller
    {
        private StarwarsConfig _starwarsConfig;
        private JediBusiness _jediBusiness;


        public JediController(StarwarsConfig starwarsConfig,
                              JediBusiness jediBusiness)
        {
            _starwarsConfig = starwarsConfig;
            _jediBusiness = jediBusiness;

            //_starwarsConfig = new StarwarsConfig();
            //_starwarsConfig.StarwarsConnectionString = "Persist Security Info=True;Initial Catalog=Starwars;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

            //_jediBusiness = new JediBusiness(_starwarsConfig);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            //TODO: Validar parametros

            var jedi = _jediBusiness.Get(id);

            /*
            var jedi = new Jedi() {
                JediId = id,
                Name = "Yoda",
                Created = DateTime.Now,
                Edited = DateTime.Now,
                Height = 120
            };
            */

            //ViewBag.Jedi = jedi;

            return View(jedi);
        }
    }
}
