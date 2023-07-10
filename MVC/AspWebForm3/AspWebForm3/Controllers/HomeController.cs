using AspWebForm3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspWebForm3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Submit(FormCollection fc) 
        {
            ViewBag.Id = fc["Id"];
            ViewBag.Name = fc["Name"];
            bool chk = Convert.ToBoolean(fc["Addon"].Split(',')[0]);
            ViewBag.Addon = chk;
            return View("Index"); 
        }
    }
}