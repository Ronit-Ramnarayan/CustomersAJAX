using CustomersAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomersAJAX.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        Customer customer;
        List<Customer> customers;
        public CustomerController()
        {
            customers = new List<Customer>();
            customers.Add(new Customer(0, "Sherry", 37));
            customers.Add(new Customer(1, "Dan", 38));
            customers.Add(new Customer(2, "Tim", 39));
            customers.Add(new Customer(3, "Jake", 40));
            customers.Add(new Customer(4, "Ron", 41));
            customers.Add(new Customer(5, "Jerry", 42));
        }
        public ActionResult Index()
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[2]);
            return View("Customer", tuple);
        }

        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[Int32.Parse(CustomerNumber)]);

            return View("Customer", tuple);
        }
    }
}