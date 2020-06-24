using Canteen_Management_System_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Canteen_Management_System_Mvc.Controllers
{
    public class MenuController : Controller
    {
        CmsContext  cm = new CmsContext();
        // GET: Menu
        /*public ActionResult Index()
        {
            return View();
        }*/
        //[HttpGet]
        /*public ActionResult AddNewMenu()
        {
            return View();
        }*/
        //[HttpPost]
        /*public ActionResult AddNewMenu(Menu menu)
        {
            m.menu.Add(menu);
            m.SaveChanges();
            ViewData["Message"] = menu.Item_Name + "is added sucessfully";
            return RedirectToAction("Index");
        }*/
        [HttpGet]
        public ActionResult ViewMenu()
        {
            //Menu mobj = new Menu();
            //mobj = m.Menus.Where(x => x.ItemId == id).FirstOrDefault();
           var mobj = cm.Menus.ToList();
            return View(mobj);
        }
        /*public ActionResult DisplayMenuList()
        
        {
            Menu m = new Menu() { ItemId = 1, ItemName = "Biryani", Cost = 100 };
            return View(m);
        }*/
        public ActionResult Index()
        {
            return View();
        }
        
    }
}