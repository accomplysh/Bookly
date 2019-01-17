using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookly.Models;
namespace Bookly.Controllers
{
    public class BooksController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            var book = new Book();
            book.Name = "Start With Why";
            

            return View(book);
        }
        [Route("books/releasedate/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
            
            
    }
}