using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Canteen_Management_System;


namespace Canteen_Management_System_Test
{

    [TestFixture]
    public class MenuTest
    {
        [Test]
        public void Testviewmenu()
        {
            Menu p = new Menu();
                string result = p.Menulist();
            Assert.AreEqual("press any key", result);
            Assert.AreNotEqual(" ", result);
        }
    }
}
