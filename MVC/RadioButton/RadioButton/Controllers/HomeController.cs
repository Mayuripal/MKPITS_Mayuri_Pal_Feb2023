using Microsoft.AspNetCore.Mvc;
using RadioButton.Models;
using System.Diagnostics;

namespace RadioButton.Controllers
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
        public ActionResult Index(UserModel u)
        {
            ViewBag.Tea = u.Tea.ToString();
            ViewBag.Loundry = u.Loundry.ToString();
            ViewBag.Breakfast = u.Breakfast.ToString();
            return View();
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