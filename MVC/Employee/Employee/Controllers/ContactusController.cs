using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    public class ContactusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
