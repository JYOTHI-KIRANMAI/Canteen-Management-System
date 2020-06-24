using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Canteen_Management_System_Mvc.Models
{
    public class Menu 
    
    { [Key]
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public int Cost { get; set; }
    }
}
