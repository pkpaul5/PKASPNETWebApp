using Microsoft.VisualStudio.TestTools.UnitTesting;
using PK.ASPNETWebApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PK.ASPNETWebApp.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            var controller = new HomeController();
            ActionResult result = controller.Index();
            Assert.AreEqual(null, controller.ViewBag.Message);
        }

        [TestMethod()]
        public void AboutTest()
        {
            var controller = new HomeController();
            ActionResult result = controller.About();
            Assert.AreEqual("Your application description page.", controller.ViewBag.Message);
        }

        [TestMethod()]
        public void ContactTest()
        {
            var controller = new HomeController();
            ActionResult result = controller.Contact();
            Assert.AreEqual("Your contact page.", controller.ViewBag.Message);
        }
    }
}