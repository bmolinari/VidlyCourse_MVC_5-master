using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Tutorial.Models;
using Vidly_Tutorial.ViewModels;

namespace Vidly_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customer()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith" },
                new Customer { Name = "Mary Williams" }
            };

            var viewModel = new CustomerModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
    }
}