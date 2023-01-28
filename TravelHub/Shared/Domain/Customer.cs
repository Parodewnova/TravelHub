﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub.Shared.Domain
{
    public class Customer
    {
        [Key]
        public int CustID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
    }
}
