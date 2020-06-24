using System;
using System.Web.Mvc;
using Canteen_Management_System_Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Canteen_Management_System_Mvc_Testing.Tests.Controllers
{
    [TestClass]
    public class VendorConrtollerTest
    {
        [TestMethod]
        public void VendorTest()
        {
           VendorController v = new VendorController();

            ViewResult result = v.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
