using Microsoft.AspNetCore.Mvc;

namespace TemplateIntegration.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
