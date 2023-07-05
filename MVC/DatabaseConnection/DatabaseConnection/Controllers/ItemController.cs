using DatabaseConnection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseConnection.Controllers
{
    public class ItemController : Controller
    {
        // ********* Display all item list **********
        public IActionResult Index()
        {
            ViewBag.ItemList = "Computer shop item list page ";
            ItemDbHandler IHandler = new ItemDbHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
        }

        // ********** Add new Item ***************
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

        // ********* Update item detail ***********
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            ItemDbHandler dbHandler = new ItemDbHandler();
            return View(dbHandler.GetItemList().Find(itemModel=>itemModel.Id == Id));
        }
        [HttpPost]
        public ActionResult Edit(int Id,ItemModel ilist)
        {
            try
            {
                ItemDbHandler dbHandler = new ItemDbHandler();
                dbHandler.UpdateItem(ilist);
                return RedirectToAction("Index");
            }
            catch { return View(); }

        }

        // *********** Delete Item **********
        public ActionResult Delete(int Id)
        {
            try
            {
                ItemDbHandler itemHandler = new ItemDbHandler();
                if(itemHandler.DeleteItem(Id))
                {
                    ViewBag.AlertMsg = "Item Deleted Sucessfully ";
                }
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }

        // ******** Show Details **********
        public ActionResult Details(int Id)
        {
            ItemDbHandler itemHandler = new ItemDbHandler();
            return View(itemHandler.GetItemList().Find(itemModel => itemModel.Id == Id));
        }
    }
}
