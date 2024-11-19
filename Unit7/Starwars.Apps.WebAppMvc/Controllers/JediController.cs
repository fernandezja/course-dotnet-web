using Microsoft.AspNetCore.Mvc;
using Starwars.Apps.WebAppMvc.Models;
using Starwars.Core.Business;
using Starwars.Core.Entities;

namespace Starwars.Apps.WebAppMvc.Controllers
{
    public class JediController : Controller
    {
        private readonly StarwarsConfig _starwarsConfig;
        private readonly JediBusiness _jediBusiness;


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
            var jedis = _jediBusiness.GetAll();

            var model = new ResultadoPaginadoViewModel<Jedi>();
            model.Titulo = "Listado de Jedis";
            model.Items = jedis;    

            return View(viewName:"Demo", 
                        model: model);
        }


        [Route("superdetail/jedi-{id}.html")]
        public IActionResult Details(int id)
        {
            //TODO: Validar parametros

            //var jedi = _jediBusiness.Get(id);

            var jedis = _jediBusiness.GetAll();

            var jedi = (from j in jedis
                        where j.JediId == id
                        select j).FirstOrDefault();

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


        [HttpGet]
        public IActionResult Create() {
            return View();
        }


        [HttpPost]
        public IActionResult Create([FromForm] Jedi jedi)
        {
            //TODO: Validar parametros
            //Guardar en la DB

            return RedirectToAction("Index");
            //return View();
        }
    }
}
