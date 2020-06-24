using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Canteen_Management_System_Mvc.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }

    }
}