using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
