using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Canteen_Management_System_Mvc.Models
{
    public class CmsContext:DbContext
    {
        public CmsContext():base("CM")
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}