using Canteen_Management_System_Mvc.Models;
using Canteen_Management_System_Mvc.ViewModel;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Schema;

namespace Canteen_Management_System_Mvc.Controllers
{
    public class OrderController : Controller
    {
        //OrderConext oc = new OrderConext();
        //MenuContext mc = new MenuContext();
        CmsContext cm = new CmsContext();
        // GET: Order


        public ActionResult Index()
        {
            return View();
            //throw new NotImplementedException();
        }
        public ActionResult Details(int OrderId)
        {
            return View("Details");
        }


        /*public ActionResult DisplayOrder()
        {
            Order o = new Order() { OrderId = 1, ItemId = 1, Quantity = 1, Total = 100, Status = "Pending"  };
            return View(o);
        }
        public ActionResult MenuList()
        {
            var Order = new Order() { OrderId = 5, ItemId = 1, Quantity = 1, Total = 100, Status = "Pending" };
            var Menu = new List<Menu>
            {
                new Menu{ ItemId = 1, ItemName = "Biryani", Cost = 100 },
                new Menu{ ItemId = 2, ItemName = "Pani Puri", Cost = 40  },
                new Menu{ ItemId = 3, ItemName = "Noodles", Cost = 50 }
            };

            var menuList = new OrderMenuViewModel()
            {
                Order = Order,
                Menus = Menu
            };
            return View(menuList);

        }*/
        [HttpGet]
        public ActionResult PlaceOrder()
        {

            return View();
        }
        [HttpPost]
        public ActionResult PlaceOrder(Order o)
        {
            //PlaceOrder o = new PlaceOrder();
            o.Status = "Pending";
            /*double cost = 1;
             foreach(var item in oc.Orders)
             {
                 if (item.ItemId == a)
                 {
                     cost = item.Cost;
                     return cost;
                 }

             }*/
            if (o.ItemId <= 0)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            if (o.Quantity <= 0)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var m = cm.Menus.SingleOrDefault(x => x.ItemId == o.ItemId);

            int cost = m.Cost;

            o.Total = o.Quantity * cost;
            cm.Orders.Add(o);
            cm.SaveChanges();
            ViewData["Message"] = o.OrderId + "is added sucessfully";
            if (o.Total >= 500)
            {
                return RedirectToAction("Voucher");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
            //public ActionResult Voucher() { }
            //[HttpPost]
           public ActionResult Voucher(string m)
            {
                m = "Thank YOU...Please collect your Gift Card at the entrance";
                return Content(m);

        }
       


    }

    }

    
