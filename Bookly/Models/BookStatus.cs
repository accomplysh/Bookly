﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class BookStatus
    {
        enum Status
        {
            CheckedOut,
            CheckedIn,
            OverDue
        };
    }
}