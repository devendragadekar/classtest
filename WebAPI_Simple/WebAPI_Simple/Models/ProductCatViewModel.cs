using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_DB_Crud.Models
{
    public class ProductCatViewModel
    {
        [Key]
        public int Productid { get; set; }
        public int CatId { get; set; }
        public string ProductName { get; set; }
        public string Catnames { get; set; }
        public decimal Price { get; set; }
    }
}
