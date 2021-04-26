using SecondHelperLibrary.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MikesMovies.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //Create a divide by 0 error
            int myAge = 0;
            int i = 5;
            var sum =   i / myAge;

            return View(sum);
        }

        //Creating a Test view for my controller 
        public ActionResult Exlab()
        {

            return View();
        }

        public ActionResult ListPeople()
        {
            //Create a list using a model then add something to that 
            List<CustomerModel> myCustomer = new List<CustomerModel>();
            myCustomer.Add(new CustomerModel
            {
                customerId = 1,
                FirstName = "First",
                LastName = "Customer",
                Email = "Test@example.com",
                ConfirmEmail = "Test@example.com",
                Password = "FindABetterPassword",
                ConfirmPassword = "FindABetterPassword",
            });

            myCustomer.Add(new CustomerModel
            {
                customerId = 1,
                FirstName = "Second",
                LastName = "Customer",
                Email = "Test2@example.com",
                ConfirmEmail = "Test2@example.com",
                Password = "FindABetterPassword2",
                ConfirmPassword = "FindABetterPassword2",
            });


            myCustomer.Add(new CustomerModel
            {
                customerId = 1,
                FirstName = "Third",
                LastName = "Customer",
                Email = "Test3@example.com",
                ConfirmEmail = "Test3@example.com",
                Password = "FindABetterPassword3",
                ConfirmPassword = "FindABetterPassword3",
            });

            return View(myCustomer);

        }
    }
}