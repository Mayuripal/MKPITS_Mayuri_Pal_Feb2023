using Form.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class ShopController : ProductController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ShopModel sm)
        {
            var SelectedValue = sm.SelectTeaType;

            ViewBag.teatype=SelectedValue.ToString();
            return View();
        }
    }
}
