using Microsoft.AspNetCore.Mvc;
using SignupForm.Models;

namespace SignupForm.Controllers
{
    public class SignupController : Controller
    {
        // Get:Signup
        public IActionResult Index()
        {
            return View();
        }

       // [HttpPost]
        public ActionResult Signup(SignupModel u)
        {
            ViewBag.Email=u.Email;
            ViewBag.Password=u.Password;
            return View();
        }
    }
}
