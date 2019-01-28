﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookly.Models;

namespace Bookly.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}