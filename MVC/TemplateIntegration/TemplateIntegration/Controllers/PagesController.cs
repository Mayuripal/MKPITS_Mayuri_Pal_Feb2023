using Microsoft.AspNetCore.Mvc;

namespace TemplateIntegration.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
