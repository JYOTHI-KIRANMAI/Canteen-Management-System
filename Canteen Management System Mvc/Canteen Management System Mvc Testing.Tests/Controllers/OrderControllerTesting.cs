using System;
using System.Web.Mvc;
using Canteen_Management_System_Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Canteen_Management_System_Mvc_Testing.Tests.Controllers
{
    [TestClass]
    public class OrderControllerTesting
    {
        [TestMethod]
            public void OrderDetails()
            {
                var c = new OrderController();
            var result = c.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
                
                
            }
        }
}
