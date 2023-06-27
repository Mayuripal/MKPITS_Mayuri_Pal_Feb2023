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
            ViewBag.password = u.Password;
            return View();
        }
    }
}
