using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Canteen_Management_System_Mvc.Controllers
{
    public class DisplayPlaceOrderController : Controller
    {
        // GET: DisplayPlaceOrder
        public ActionResult Index()
        {
            return Content("Place Your Order");
        }
    }
}