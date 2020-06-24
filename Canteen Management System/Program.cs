using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Canteen_Management_System
{
    public class Program
    {
        Menucrud mc = new Menucrud();
        Ordercrud oc = new Ordercrud();
        public void mainmenu()
        {
            Console.WriteLine("canteen management");
            Console.WriteLine("............");
            Console.WriteLine("1.customer");
            Console.WriteLine("2.vendor");
            Console.WriteLine("3.exit");
            Console.WriteLine("enter your choice");
            int s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {
                case 1:
                    cust();
                    break;
                case 2:
                    vend();
                    break;

            }



            void cust()
            {

                Console.WriteLine("1.menu list");
                Console.WriteLine("2.place order");
                Console.WriteLine("3.exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        viewMenu();
                        break;
                    case 2:
                        placeorder();
                        break;
                }
                void viewMenu()
                {
                    //    List<Menu> ml = new List<Menu>();
                    //    Menu m1 = new Menu(1, "biryani", 200);
                    //    Menu m2 = new Menu(2, "soup", 100);
                    //    Menu m3 = new Menu(3, "noodles", 100);
                    //    Menu m4 = new Menu(4, "pav bhaji", 50);
                    //    Menu m5 = new Menu(5, "cool drinks", 30);
                    //    Menu m6 = new Menu(6, "chocolate", 80);
                    //    Menu m7 = new Menu(7, "juice", 40);
                    //    Menu m8 = new Menu(8, "samosa", 30);
                    //    Menu m9 = new Menu(9, "kachori", 40);
                    //    Menu m10 = new Menu(10, "veg fries", 120);
                    //    ml.Add(m1);
                    //    ml.Add(m2);
                    //    ml.Add(m3);
                    //    ml.Add(m4);
                    //    ml.Add(m5);
                    //    ml.Add(m6);
                    //    ml.Add(m7);
                    //    ml.Add(m8);
                    //    ml.Add(m9);
                    //    ml.Add(m10);
                    //    foreach (var item in ml)
                    //    {
                    //        Console.WriteLine(item.ItemId);
                    //        Console.WriteLine(item.ItemName);
                    //        Console.WriteLine(item.Cost);
                    //    }
                    mc.ReadData();
                    mainmenu();
                    
                    //mc.RetriveData();

                }
                 void placeorder()
                {
                    //placeorder po = new placeorder();
                    //List<Menu> ml = new List<Menu>();
                    //Menu m1 = new Menu(1, "biryani", 200);
                    //Menu m2 = new Menu(2, "soup", 100);
                    //Menu m3 = new Menu(3, "noodles", 100);
                    //Menu m4 = new Menu(4, "pav bhaji", 50);
                    //Menu m5 = new Menu(5, "cool drinks", 30);
                    //Menu m6 = new Menu(6, "chocolate", 80);
                    //Menu m7 = new Menu(7, "juice", 40);
                    //Menu m8 = new Menu(8, "samosa", 30);
                    //Menu m9 = new Menu(9, "kachori", 40);
                    //Menu m10 = new Menu(10, "veg fries", 120);
                    //ml.Add(m1);
                    //ml.Add(m2);
                    //ml.Add(m3);
                    //ml.Add(m4);
                    //ml.Add(m5);
                    //ml.Add(m6);
                    //ml.Add(m7);
                    //ml.Add(m8);
                    //ml.Add(m9);
                    //ml.Add(m10);
                    Console.WriteLine("Enter item id");
                    Console.WriteLine("enter the item quantity");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    double cost = Convert.ToDouble(mc.RetriveData(a));
                    double total;
                    string stat = "pending";
                    int oid = oc.Count() + 1;
                    //foreach (var item in ml)
                    //{
                    //    if (item.ItemId == a)
                    //    {
                    //        cost = item.Cost;
                    //        break;
                    //    }
                    //}
                    total = b * cost;
                    Console.WriteLine(total);
                    //List<Order> od = new List<Order>();
                    Order o = new Order(oid, a, b, total, stat);
                    oc.CreateData(o);
                    Console.WriteLine("your order is placed");

                }
                //List<Order> od1 = new List<Order>();
                //foreach (var orderdetails in od1)
                //{
                //    Console.WriteLine("your order details are");
                //    Console.WriteLine(orderdetails.OrderId);
                //    Console.WriteLine(orderdetails.ItemId);
                //    Console.WriteLine(orderdetails.Quantity);
                //    Console.WriteLine(orderdetails.Total);
                //    Console.WriteLine(orderdetails.Status);


                //}
                oc.ReadData();
                mainmenu();
            }


            void vend()
            {
                Boolean b = oc.AcceptorReject();
                Console.WriteLine("Enter the order Id you want to accept or reject");
                int OrderId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the status");
                string Status = Console.ReadLine();
                int a = oc.UpdateOrderStatus(OrderId, Status);
                Console.WriteLine("Your order is " +Status);
               mainmenu();
            }



        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.mainmenu();
        }
    }

}