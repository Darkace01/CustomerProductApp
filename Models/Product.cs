using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProductApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int Tax { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
