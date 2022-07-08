using assign1.Data;
using assign1.Models;
using Microsoft.AspNetCore.Mvc;


namespace assign1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private DataContext _dataContext;

        public IActionResult Index()
        {
            return View();
        }

        public HomeController(DataContext context)
        {
            _context = context;
            _dataContext = context;
        }

        public IActionResult about()
        {
            ViewBag.message = "LOGIN";
            return View();
        }

        [HttpPost]
        public IActionResult formsend(information_customer s)
        {
            _dataContext.information_customer.Add(s);
            _dataContext.SaveChanges();
            return View("contact");
        }

        public IActionResult contact()
        {
            return View();
        }

        public IActionResult table()
        {
            return View(_context.information_customer.ToList());
        }


    }
}
