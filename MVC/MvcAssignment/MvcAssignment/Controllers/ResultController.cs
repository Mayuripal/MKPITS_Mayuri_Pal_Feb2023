using Microsoft.AspNetCore.Mvc;
using MvcAssignment.Models;
using System.Numerics;

namespace MvcAssignment.Controllers
{
    public class ResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ResultModel rm)
        {
            int sub1 = rm.m1;
            int sub2 = rm.m2;
            int sub3 = rm.m3;
            int sub4 = rm.m4;
            int sub5 = rm.m5;

            int total=sub1 + sub2+sub3+sub4+sub5;

            double per = total / 5;

            string grade;
            if (per >80)
            {
                grade = "Distinction";
            }
            else if (per >60 & per <80)
            {
                grade = "First Class";
            }
            else
            {
                grade = "Fail";
            }

            ViewBag.total=total;
            ViewBag.per=per;
            ViewBag.grade=grade;
            return View(rm);
        }
    }
}
