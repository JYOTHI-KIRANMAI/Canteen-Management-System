using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Canteen_Management_System;


namespace Canteen_Management_System_Test
{

    [TestFixture]
    public class OrderTest
    {
        [Test]
        public void TestPlaceOrder()
        {
            Order o = new Order();
             double result = o.Orderamount(2,3);
              Assert.AreEqual(300, result);
            Assert.AreNotEqual(" ", result);
        }
    }
}
