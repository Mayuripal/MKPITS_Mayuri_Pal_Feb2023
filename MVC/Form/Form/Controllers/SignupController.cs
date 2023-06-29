using Form.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SignupModel um)
        {
            ViewBag.UserName=um.UserName;
            ViewBag.Gender = um.gender;

            var ct = um.SelectCity;
            ViewBag.City = ct.ToString();
            ViewBag.sub1 = null;
            ViewBag.sub2=null;
            if(um.sub1 == true)
            {
                ViewBag.sub1 = "Dotnet";
            }
            else if (um.sub2 == true)
            {
                ViewBag.sub2 = "Java";
            }
            return View();
        }
    }
}
