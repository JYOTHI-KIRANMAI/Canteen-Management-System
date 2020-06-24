using System;
using System.Web.Mvc;
using Canteen_Management_System_Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Canteen_Management_System_Mvc_Testing.Tests.Controllers
{
    [TestClass]
    public class MenuControllerTest
    {
        [TestMethod]
        public void Menu()
        {
            MenuController c = new MenuController();
             
            ViewResult result = c.Index() as ViewResult;

            Assert.IsNotNull(result);


        }
    }
}
