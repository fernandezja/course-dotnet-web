using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //return Content(".NET Web");
            return Content(content: "<html><body>.NET <strong>Web<strong></body></html>", 
                           contentType: "text/html");
        }


        [Route("carpeta3/demo")]
        [Route("demo3")]
        public IActionResult Demo3()
        {
            //return Content(".NET Web");
            return Content(content: "<html><body>.NET <strong>Web DEMO 3<strong></body></html>", 
                           contentType: "text/html");
        }
    }
}
