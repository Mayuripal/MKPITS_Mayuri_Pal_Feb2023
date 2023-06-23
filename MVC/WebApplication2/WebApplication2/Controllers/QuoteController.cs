using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class QuoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
