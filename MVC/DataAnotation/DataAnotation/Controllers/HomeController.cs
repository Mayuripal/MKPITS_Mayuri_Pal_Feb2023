using DataAnotation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DataAnotation.Models;

namespace DataAnotation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentDetail(StudentModel sm)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Name=sm.Name;
                ViewBag.Email=sm.Email;
                ViewBag.Age=sm.Age;
                return View("Index");
            }
            else
            {
                ViewBag.Name = "No Data";
                ViewBag.Email = "No Data";
                ViewBag.Age = "No Data ";
                return View("Index");
            }
            
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}