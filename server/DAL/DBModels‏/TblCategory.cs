using System;
using System.Collections.Generic;

namespace server.DBModels‏
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblProducts = new HashSet<TblProducts>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<TblProducts> TblProducts { get; set; }
    }
}
