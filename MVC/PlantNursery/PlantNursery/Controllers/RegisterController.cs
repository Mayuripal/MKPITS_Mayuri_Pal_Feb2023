using Microsoft.AspNetCore.Mvc;
using PlantNursery.Models;

namespace PlantNursery.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Register(Register r)
        {
            ViewBag.firstname = r.FirstName;
            ViewBag.lastname=r.LastName;
            ViewBag.email = r.Email;
            string psw = r.Password;
            if (psw == "123456")
            {
                ViewBag.password = "Login Sucessfully";
            }
            else
            {
                ViewBag.password = "Incorrect Pasword";
            }
            ViewBag.mob=r.Mobile;
            return View();
        }
    }
}
