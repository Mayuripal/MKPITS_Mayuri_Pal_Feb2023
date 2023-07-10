using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspWebForm2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form2(Models.UserModel um)
        {
            ViewBag.Id = um.Id;
            ViewBag.Name= um.Name;
            if(um.Addon==true)
            {
                ViewBag.Addon = "selected";
            }
            else
            {
                ViewBag.Addon = "Not Selected";
            }
            return View("Index");
        }
    }
}