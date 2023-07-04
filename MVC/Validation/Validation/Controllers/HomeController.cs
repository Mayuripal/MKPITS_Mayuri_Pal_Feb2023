using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Validation.Models;

namespace Validation.Controllers
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
            if(string.IsNullOrEmpty(sm.Name))
            {
                ModelState.AddModelError("Name", "Name Required");
            }
            if(sm.Age ==0 || sm.Age >100)
            {
                ModelState.AddModelError("Age", "Enter proper Age");
            }

            if (ModelState.IsValid)
            {
                ViewBag.Name = sm.Name;
                ViewBag.Age = sm.Age;
                return View("Index");
            }
            else
            {
                ViewBag.Name ="No Data";
                ViewBag.Age = "No Data";
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