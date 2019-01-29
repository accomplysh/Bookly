using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Bookly.Models;
using Bookly.ViewModels;

namespace Bookly.Controllers
{
    public class BooksController : Controller
    {
        private BooklyContext _context;
        // GET: Book
        public BooksController()
        {
            _context = new BooklyContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var books = _context.Books.Include(cat => cat.BookCategory).ToList();
           
            

            return View(books);
        }
        public ActionResult Add()
        {
            var categories = _context.BookCategories.ToList();

            var viewModel = new AddBookViewModel
            {
                BookCategories = categories
            };

            return View("AddBookForm", viewModel);
        }

        [Route("books/releasedate/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
            
            
    }
}