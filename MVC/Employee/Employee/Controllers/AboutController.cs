using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
