using System;
using System.Collections.Generic;

namespace server.DBModels‏
{
    public partial class TblShopDetails
    {
        public int ShopId { get; set; }
        public int? ShoppingId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }

        public TblProducts Product { get; set; }
        public TblShopping Shopping { get; set; }
    }
}
