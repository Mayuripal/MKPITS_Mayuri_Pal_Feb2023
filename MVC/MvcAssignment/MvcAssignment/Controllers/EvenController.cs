using Microsoft.AspNetCore.Mvc;
using MvcAssignment.Models;

namespace MvcAssignment.Controllers
{
    public class EvenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalculateModel c)
        {
            int n1 = c.num1;
            string res;

            if (n1%2 == 0)
            {
                res = "even";
            }
            else
            {
                res = "odd";
            }

            ViewBag.result = res;
            return View();
        }
    }
}
