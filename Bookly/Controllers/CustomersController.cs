using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookly.Models;

namespace Bookly.Controllers
{
    public class CustomersController : Controller
    {
        private BooklyContext _context;

        public CustomersController()
        {
            _context = new BooklyContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();

          
         //   var customers = GetCustomers();
            
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            /* Step 1
             * When the Customer/Index.cshtml page first loads, GetCustomers() method executes, creates two instances of Customer class,
             * initializes their properties and then displays it in the Customer/Index.cshml page.
             * Using the foreach loop, each name is displayed.
             * It parses each name as a hyperlink using the @HtmlActionLink method.
             * @HtmlActionLink includes A. Link name, ActionResult method, Controller Name, and one or more Parameters.
             * When a specific link is clicked, it routes to the Controller Name, executes the ActionResult in that controller, passes the parameters
             * With their initialized values, and then shows the View with the updated data.
                         
             * Step 2
             * Details Page
             * The reason c.Id works (c => c.Id == id), is because the SingleOrDefault predicate checks the type of GetCustomers, which is Customer.
             * It then checks the available class properties and enables access to those properties.
             * Which then allows accessing the data of the properties of a specific customer.
             */
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        
        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer  { FirstName = "Albert", LastName = "Pinhasov", Id = 1},
                new Customer  { FirstName = "Bill", LastName = "Gates", Id = 2}
            };

            return customers;
        }
    }
}