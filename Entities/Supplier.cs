using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Supplier
    {
        public Supplier() { }
        [Key]
        public int SupplierId { get; set; }
        public long RUC { get; set; }
        public string BusinessName { get; set; }
        public string TradeName { get; set; }
        public string Kind { get; set; }
        public string Department { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Direction { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
    }
}
