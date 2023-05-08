using System;
using System.Collections.Generic;

namespace server.DBModels‏
{
    public partial class TblShopping
    {
        public TblShopping()
        {
            TblShopDetails = new HashSet<TblShopDetails>();
        }

        public int ShoppingId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? ShopDate { get; set; }
        public decimal? AmountToPay { get; set; }

        public TblCustomers Customer { get; set; }
        public ICollection<TblShopDetails> TblShopDetails { get; set; }
    }
}
