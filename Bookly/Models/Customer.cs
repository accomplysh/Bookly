using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Bookly.Models
{
    public class Customer
    {
        [Required]
        [MaxLength(255)]
        [Display(Name = "First name:")]

        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name:")]
        public string LastName { get; set; }

        public int Id { get; set; }

        [Required]
        public Address Address { get; set; }

        [Display(Name = "Date of Birth:")]
        public DateTime DOB { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte? MembershipTypeId { get; set; }

        

    }
}