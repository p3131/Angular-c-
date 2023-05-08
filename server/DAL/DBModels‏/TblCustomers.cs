using System;
using System.Collections.Generic;

namespace server.DBModels‏
{
    public partial class TblCustomers
    {
        public TblCustomers()
        {
            TblShopping = new HashSet<TblShopping>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public string CreditInformation { get; set; }

        public ICollection<TblShopping> TblShopping { get; set; }
    }
}
