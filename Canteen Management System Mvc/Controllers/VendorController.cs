using Canteen_Management_System_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Canteen_Management_System_Mvc.ViewModel;
using System.Runtime.InteropServices;
using System.Data.Entity;

namespace Canteen_Management_System_Mvc.Controllers
{
    public class VendorController : Controller
    {
        //private CmsContext _cm;
        CmsContext cm = new CmsContext();
        // GET: Vendor
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DisplayVendor()
        {
            
            var mobj = cm.Vendors.ToList();
            return View(mobj);
            
            //
            //var m = cm.Menus.SingleOrDefault(x => x.ItemId == o.ItemId);
        }
        /*public ActionResult OrderList()
        {
            var Vendor = new Vendor() { VendorName = "Jyothi", VendorId = 201, VendorEmail = "Jyothi@gmail.com" };
            var Orders = new List<Order>
            {
                new Order{ OrderId = 2, ItemId = 1, Quantity = 1, Total =100, Status = "Pending" },
                new Order{ OrderId = 3, ItemId = 2, Quantity = 1, Total =50, Status = "Pending" },
                new Order{ OrderId = 4, ItemId = 3, Quantity = 1, Total =30, Status = "Pending" }
            };

            var vendorList = new VendorOrdersViewModel()
            {
                Vendor = Vendor,
                Orders = Orders
            };
            return View(vendorList);

        }*/
        [HttpGet]
        public ActionResult DisplayPendingOrders()
        {
            var m = cm.Orders.ToList();

            return View(m.FindAll(x => x.Status.Equals("Pending")));

        }
        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            //Order cm2 = cm.Orders.SingleOrDefault(x => x.OrderId == OrderId);
            Order cm2 = cm.Orders.Find(Id);
            if (cm2 == null)
            {
                return HttpNotFound();
            }
            return View(cm2);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order cm1)
        {
            if (cm1 != null)
            {
                if (ModelState.IsValid)
                {
                var ed = cm.Orders.SingleOrDefault(x => x.OrderId == cm1.OrderId);
                //cm.Entry(cm1).State = EntityState.Modified;
                    ed.Status = cm1.Status;
                    cm.SaveChanges();
                    return RedirectToAction("DisplayPendingOrders");
                }
            }
            return View(cm1);
        }
    }
}