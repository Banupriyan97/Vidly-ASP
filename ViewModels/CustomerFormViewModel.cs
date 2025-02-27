﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_ASP.Models;

namespace Vidly_ASP.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}