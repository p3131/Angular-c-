using System;
using System.Collections.Generic;
using System.Text;

namespace common
{
    public class ProductsVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Picture { get; set; }
        public string Color { get; set; }
        public int? Size { get; set; }
        public int QuantityInStock { get; set; }
    }
}
