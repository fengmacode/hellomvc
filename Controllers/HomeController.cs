using Microsoft.AspNetCore.Mvc;

namespace HelloMvc
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();
        
        [HttpGet("/about")]
        public ActionResult About(){
            return Json("ok23234");
        }
    }
}