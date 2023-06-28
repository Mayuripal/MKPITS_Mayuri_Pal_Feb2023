using Form.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class AccountController : ProductController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BankModel bm)
        {
            int bal = 1000;
            int actno = bm.AccountNumber;
            int amt = bm.Amount;
            var tt = bm.GetTranstype;
            string type=tt.ToString();

            switch(type)
            {
                case "Deposite":
                    bal=bal+amt; 
                    break;
                case"Widthdraw":
                    bal=bal-amt;
                    break;
            }

            ViewBag.AccountNumber = actno;
            ViewBag.BalAmount=bal;

            return View();
        }
    }
}
