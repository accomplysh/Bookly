using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Year Published")]
        [Required]
        public int YearPublished { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string ISBN { get; set; }
        public BookCategory BookCategory { get; set; }

       // public Customer Customer { get; set; }


        enum Status
        {
            CheckedOut,
            CheckedIn,
            Overdue
        };

        enum CheckoutDuration
        {
            OneWeek,
            TwoWeeks,
            ThreeWeeks
        }

       
    }
}