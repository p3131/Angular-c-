using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DBModels_
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {

        }

        public int ProductId { get; set; }   

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal FinalPrice { get; set; }

    }
}
