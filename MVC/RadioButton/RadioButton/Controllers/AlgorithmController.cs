using Microsoft.AspNetCore.Mvc;
using RadioButton.Models;

namespace RadioButton.Controllers
{
    public class AlgorithmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AlgorithmModel u)
        {
            ViewBag.number1 = u.number1;
            ViewBag.number2 = u.number2;
            string b = u.caltype.ToString();
            int result = 0;

            if (b == "add")
            {
                result = u.number1 + u.number2;

            }
            else if (b == "sub")
            {
                result = u.number1 - u.number2;

            }
            else if (b == "mul")
            {
                result = u.number1 * u.number2;

            }
            ViewBag.res = result;

            return View();
        }

    }
}
