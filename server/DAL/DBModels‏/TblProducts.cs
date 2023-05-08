using System;
using System.Collections.Generic;

namespace server.DBModels‏
{
    public partial class TblProducts
    {
        public TblProducts()
        {
            TblShopDetails = new HashSet<TblShopDetails>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Picture { get; set; }
        public string Color { get; set; }
        public int? Size { get; set; }
        public int QuantityInStock { get; set; }

        public TblCategory Category { get; set; }
        public ICollection<TblShopDetails> TblShopDetails { get; set; }
    }
}
