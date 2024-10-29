using Microsoft.AspNetCore.Mvc;
using Starwars.Apps.WebMvcApp.Models;
using Starwars.Core.Business;
using Starwars.Core.Entities.Filters;
using System.Diagnostics;

namespace Starwars.Apps.WebMvcApp.Controllers
{
    public class JediController : Controller
    {
        private readonly ILogger<JediController> _logger;
        private readonly JediBusiness _jediBusiness;

        public JediController(ILogger<JediController> logger,
                              JediBusiness jediBusiness)
        {
            _logger = logger;
            _jediBusiness = jediBusiness;
        }

        public IActionResult Index(string id)
        {
            var filter = new JediFilter() {
                Name = id,
                PageIndex = 1,
                PageSize = 10
            };
            var jedis = _jediBusiness.SearchWithStoreProcedure(filter);

            return View(jedis);
        }
    }
}
