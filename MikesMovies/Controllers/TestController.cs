
using static SecondHelperLibrary.LogicClasses.BusinessLogic.customerProcessor;
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
        public ActionResult TestIndex()
        {
            //Create a divide by 0 error
            //int myAge = 0;
            //int i = 5;
            //var sum =   i / myAge;

            return View();
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
                customer_Id = 1,
                first_name = "First",
                last_name = "Customer",
                email = "Test@example.com",
                phone = "07700900314",
                confirm_email = "Test@example.com",
                password = "FindABetterpassword",
                confirm_password = "FindABetterPassword",
            });

            myCustomer.Add(new CustomerModel
            {
                customer_Id = 2,
                first_name = "Second",
                last_name = "Customer",
                email = "Test2@example.com",
                phone = "07700900605",
                confirm_email = "Test2@example.com",
                password = "FindABetterPassword2",
                confirm_password = "FindABetterPassword2",
            });


            myCustomer.Add(new CustomerModel
            {
                customer_Id = 3,
                first_name = "Third",
                last_name = "Customer",
                email = "Test3@example.com",
                phone = "07700900283",
                confirm_email = "Test3@example.com",
                password = "FindABetterPassword3",
                confirm_password = "FindABetterPassword3",
            });

            return View(myCustomer);

        }

        public ActionResult ListDbPeople()
        {
            ViewBag.Message = "Customer List";

            var data = LoadCustomers();

            List<CustomerModel> customers = new List<CustomerModel>();

            foreach (var row in data)
            {
                customers.Add(new CustomerModel
                {
                    customer_Id = row.customer_Id,
                    first_name = row.first_name,
                    last_name = row.last_name,
                    phone = row.phone,
                    email = row.email,
                    confirm_email = row.email
                });
            }

            return View(customers);
        }

        //Creating a get view for customers to sign up to the website
        public ActionResult SignUp()
        {
            ViewBag.Message = "Sign up here !";

            return View();
        }

        //Creating a post view for customers to sign up to the website
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
               int recordsCreated =  CreateCustomer(
                    model.customer_Id, 
                    model.first_name, 
                    model.last_name, 
                    model.email,
                    model.phone);
                return RedirectToAction("Index");
            }

            return View();
        }


    }
}