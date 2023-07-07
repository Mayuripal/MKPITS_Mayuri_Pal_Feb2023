using ProductDropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace ProductDropdown.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details()
        {
            bindState();
            return View();
        }

        public void bindState()
        {
            DataModel modelDemo = new DataModel();
            var category = modelDemo.tblCategories.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "--Select Categories--", Value = "0" });

            foreach (var m in category)
            {

                li.Add(new SelectListItem { Text = m.Categoryname, Value = m.Categoryid.ToString() });
                ViewBag.state = li;

            }
        }
    }
}