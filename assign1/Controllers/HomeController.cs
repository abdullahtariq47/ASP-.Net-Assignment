using Microsoft.AspNetCore.Mvc;

namespace assign1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult about()
        {
            return View();
        }
    }
}
