using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Canteen_Management_System_Mvc.Models;

namespace Canteen_Management_System_Mvc.ViewModel
{
    public class OrderMenuViewModel
    {
        public Order Order { get; set; }
        public List<Menu> Menus { get; set; }
    }
}