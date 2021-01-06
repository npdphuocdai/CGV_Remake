﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class dtoViewCustomer
    {
        public int CustomerID { get; set; }
        public string Gender { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime? CustomerBirthDay { get; set; }
        public string CustomerAddress { get; set; }
    }
}
