using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Starwars.Core.Business;
using Starwars.Core.Entities;

namespace Starwars.Apps.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JediController : ControllerBase
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


        [HttpGet("{id}")]
        public Jedi Get(int id)
        {
            //TODO: Validar parametros

            //var jedi = _jediBusiness.Get(id);

            var jedis = _jediBusiness.GetAll();

            var jedi = (from j in jedis
                        where j.JediId == id
                        select j).FirstOrDefault();

            
            return jedi;
        }
    }
}
