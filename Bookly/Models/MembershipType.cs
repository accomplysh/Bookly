using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public int Fee { get; set; }
        public int DurationInMonths { get; set; }

    }
}