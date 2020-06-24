using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Canteen_Management_System
{
    public class Order
    {
        private int orderId;
        private int itemId;
        private int quantity;
        private double total;
        private String status;
        public Order() { }
        public Order(int orderId, int itemId, int quantity, double total, String status)
        {
            this.orderId = orderId;
            this.itemId = itemId;
            this.quantity = quantity;
            this.total = total;
            this.status = status;
        }
        public int OrderId
        {
            get
            {
                return this.orderId;
            }
            set
            {
                this.orderId = value;
            }
        }
        public int ItemId
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
            }
        }
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }
        public double Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }
        public String Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
      public double Orderamount(int a, int b)
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
            double cost = 1;
            foreach (var item in ml)
            {
                if (item.ItemId == a)
                {
                    cost = item.Cost;
                    break;
                }
            }
            return total = b * cost;

        }

    }
}