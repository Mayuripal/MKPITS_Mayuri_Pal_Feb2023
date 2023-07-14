using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using ComboboxUsingAjax.Models;

namespace ComboboxUsingAjax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CascadingModel model = new CascadingModel();//this will call constructor
            model.Country=
            return View();
        }
    }
}