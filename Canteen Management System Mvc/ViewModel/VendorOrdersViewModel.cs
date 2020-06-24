using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Canteen_Management_System_Mvc.Models;

namespace Canteen_Management_System_Mvc.ViewModel
{
    public class VendorOrdersViewModel
    {
        public Vendor Vendor { get; set; }

        public List<Order> Orders { get; set; }
    }
}