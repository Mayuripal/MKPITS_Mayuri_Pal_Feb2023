using Microsoft.AspNetCore.Mvc;
using MvcAssignment.Models;

namespace MvcAssignment.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ProductModal pm)
        {
            string name = pm.ProductName;
            int p = pm.Price;
            int q = pm.Qty;

            int res = p * q;
            ViewBag.result = res;
            ViewBag.name=name;
            return View();
        }
    }
}
