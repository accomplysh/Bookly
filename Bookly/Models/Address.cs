using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Address
    {
        public string AddressName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}