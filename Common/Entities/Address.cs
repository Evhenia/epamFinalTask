﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Address
    {
        public string Country { get; set; }

        public string City { get; set; }

        public int PostCode { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public int? ApartmentId { get; set; }
    }
}
