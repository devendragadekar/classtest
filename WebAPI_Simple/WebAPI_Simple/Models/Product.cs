﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_DB_Crud.Models
{
    public class Product
    {
        public int Productid { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public int CatId { get; set; }
    }
}
