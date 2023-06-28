using Form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Form.Controllers
{
    public class HomeController : ProductController
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
        public ActionResult Index(IFormCollection fc,UserModel um)
        {
            if (ModelState.IsValid)
            {
                um.UserName = fc["UserName"];
                return View(um);
            }
            else
            {
                return View();
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