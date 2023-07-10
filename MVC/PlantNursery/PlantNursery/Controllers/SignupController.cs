using Microsoft.AspNetCore.Mvc;
using PlantNursery.Models;

namespace PlantNursery.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
        public ActionResult Signup(SignUpModel u)
        {
            ViewBag.email = u.Email;
            string psw = u.Password;
            if (psw == "123456")
            {
                ViewBag.password = "Login Sucessfully";
            }
            else
            {
                ViewBag.password = "Incorrect Pasword";
            }
            return View();
        }

  
        public ActionResult Register(SignUpModel u)
        {
            ViewBag.email = u.Email;
            string psw = u.Password;
            if (psw == "123456")
            {
                ViewBag.password = "Login Sucessfully";
            }
            else
            {
                ViewBag.password = "Incorrect Pasword";
            }
            return View();
        }
    }
}
