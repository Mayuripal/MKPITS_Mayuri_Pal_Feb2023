using Form.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ProductDetailsModel pd)
        {
            int onum = pd.OrderNumber;
            string custname = pd.CustomerName;
            int price = pd.price;
            int qty=pd.qty;
            int tp = qty * price;

            var selectedvalue = pd.GetProductName;
            ViewBag.productname=selectedvalue.ToString();
            ViewBag.totalprice=tp;
            ViewBag.ordernumber = onum;
            ViewBag.Name = custname;

            return View();

        }
    }
}
