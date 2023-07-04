using DatabaseConnection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseConnection.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Add new Item 
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemModel ilist) 
        {
            if (ModelState.IsValid)
            {
                ItemDbHandler dbHandler = new ItemDbHandler();
                if(dbHandler.InsertItem(ilist))
                {
                    ViewBag.message = "item saved sucessfully";
                    ModelState.Clear();
                }
            }
            return View();
        }
    }
}
