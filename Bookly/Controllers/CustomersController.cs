using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookly.Models;
using Bookly.ViewModels;

namespace Bookly.Controllers
{
    public class CustomersController : Controller
    {
        private BooklyContext _context;

        public CustomersController()
        {
            _context = new BooklyContext();
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new NewCustomerFormViewModel
            {
                Customer =  customer,
                MembershipTypes = _context.MembershipTypes.ToList(),
               // Address = _context.Addresses.SingleOrDefault(a => a.Id == customer.Address.Id)
                
            };

            return View("NewCustomerForm",viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
       
        public ActionResult NewCustomer()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var customerViewModel =  new NewCustomerFormViewModel
            {
                MembershipTypes = membershipTypes,                
            };
            return View("NewCustomerForm",customerViewModel);
        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer); 
            }
            else
            {
                var updateCustomer = _context.Customers.Single(c => c.Id == customer.Id);
                updateCustomer.FirstName = customer.FirstName;
                updateCustomer.LastName = customer.LastName;
                updateCustomer.DOB = customer.DOB;
                updateCustomer.MembershipTypeId = customer.MembershipTypeId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }


        // GET: Customers
        public ActionResult Index()
        {
            /* Include method load related objects of class. In this instance Address it a related class to Customer class
             * As defined in the Customer class.             
             */
            var customers = _context.Customers.Include(c => c.Address).ToList();

          
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
            
            //Select statement returns a boolean instead of records
            //var bookStatus = _context.BookStatus.Select(cu => cu.Customer.Id == id).ToList();
            //var bookStatus = new List<BookStatus>()
            //{
            //    new BookStatus
            //    {
            //        Book = new Book(),
            //        Customer = new Customer()
                    
            //    }
                
            //};
           
            var customer = _context.Customers.Include(m => m.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            //var CustomerBooksVM = new CustomerBooksViewModel()
            //{
            //    BookStatuses = bookStatus,
            //    Customer = customer
            //};
            return View(customer);
        }
        /* Not Used after Section 3 - video 29 */
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