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
            ViewBag.message = "LOGIN";
            return View();
        }

        public IActionResult formsend(string name, string lname, string email, double phone, string gender, string department, string mess)
        {
            if(name != "" && lname != "" && email != "" && phone != null && gender != "" && department != "" && mess !="")
            {
                ViewBag.message = "Received data";
            }
            else
            {
                ViewBag.message = "Fail data received";
            }
            return View("about");
        }
    }
}
