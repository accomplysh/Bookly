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
       
        public string Name { get; set; }
        public int YearPublished { get; set; }
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

        enum Category
        {
            Biography,
            Business,
            Science,
            Sports,
            SelfHelp,
            Religion,
            Programming,
            Design,
            Travel,
            Literature
        }
    }
}