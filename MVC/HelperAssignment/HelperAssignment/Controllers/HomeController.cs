using HelperAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelperAssignment.Controllers
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
        public ActionResult Logical(LogicalModel lm)
        {
            int n1 = lm.Num1;
            int n2 = lm.Num2;
            string num;
            if(n1 > n2)
            {
                num = (n1 + "is greater than" +n2);
                ViewBag.num=num;
            }
            if(n2 > n1)
            {
                num = (n2 + "is greater than" + n1);
                ViewBag.num = num;
            }
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