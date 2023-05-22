using Microsoft.AspNetCore.Mvc;

namespace WebFYP.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
