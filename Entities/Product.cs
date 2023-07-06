using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public Product() { }
        [Key]
        public int Code { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }
        public float PurchasePrice { get; set; }
        public float SalePrice { get; set; }
        public int SupplierId { get; set; }
    }
}
