using Microsoft.VisualStudio.TestTools.UnitTesting;
using MikesMovies;
using MikesMovies.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace MikesMovies.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Creating some failing tests
        [TestMethod]
        public void IndexIsnull()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }


        //Creating some failing tests
        [TestMethod]
        public void AboutIsnull()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.About() as ViewResult;

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        //Creating some failing tests
        [TestMethod]
        public void ContactIsnull()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Contact() as ViewResult;

            //Assert
            Assert.IsNull(result);
        }
    }
}
