using StudentMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Addmision = "Student registered ";
            StudentDbHandler handler = new StudentDbHandler();
            ModelState.Clear();
            return View(handler.GetRecords());
        }

        // ********** Add new Detail***************
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel sdetail)
        {
            if(ModelState.IsValid)
            {
                StudentDbHandler dbHandler = new StudentDbHandler();
                if(dbHandler.InsertRecord(sdetail))
                {
                    ViewBag.message = "Student Registered sucessfully";
                    ModelState.Clear();
                }
            }
            return View();
        }

        // ********* Update Student detail ***********
        [HttpGet]
        public ActionResult Edit(int Rollno)
        {
            StudentDbHandler dbHandler = new StudentDbHandler();
            return View(dbHandler.GetRecords().Find(studModel => studModel.Rollno == Rollno));
        }
        [HttpPost]
        public ActionResult Edit(int Rollno, StudentModel sdetail)
        {
            try
            {
                StudentDbHandler dbHandler = new StudentDbHandler();
                dbHandler.UpdateRecord(sdetail);
                return RedirectToAction("Index");
            }
            catch {  return View(); }
        }
    }
}