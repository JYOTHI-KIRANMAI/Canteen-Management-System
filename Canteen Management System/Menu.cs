using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen_Management_System
{
    public class Menu
    {
        private int itemId;
        private String itemName;
        private int cost;
        public Menu() { }
        public Menu(int itemId, String itemName, int cost)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.cost = cost;
        }

        public int ItemId
        {
            get { return this.itemId; }
            set { this.itemId = value; }
        }
        public String ItemName
        {
            get { return this.itemName; }
            set { this.itemName = value; }
        }
        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }
        public string Menulist()
        {
            List<Menu> ml = new List<Menu>();
            Menu m1 = new Menu(1, "biryani", 200);
            Menu m2 = new Menu(2, "soup", 100);
            Menu m3 = new Menu(3, "noodles", 100);
            Menu m4 = new Menu(4, "pav bhaji", 50);
            Menu m5 = new Menu(5, "cool drinks", 30);
            Menu m6 = new Menu(6, "chocolate", 80);
            Menu m7 = new Menu(7, "juice", 40);
            Menu m8 = new Menu(8, "samosa", 30);
            Menu m9 = new Menu(9, "kachori", 40);
            Menu m10 = new Menu(10, "veg fries", 120);
            ml.Add(m1);
            ml.Add(m2);
            ml.Add(m3);
            ml.Add(m4);
            ml.Add(m5);
            ml.Add(m6);
            ml.Add(m7);
            ml.Add(m8);
            ml.Add(m9);
            ml.Add(m10);
            foreach (var item in ml)
            {
                Console.WriteLine(item.ItemId);
                Console.WriteLine(item.ItemName);
                Console.WriteLine(item.Cost);
            }
            //Console.WriteLine("press any key to go back");
            //Console.ReadLine();
            //cust();
            return "press any key";
        }
    }
}
   

