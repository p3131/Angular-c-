using DAL.DBModels_;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IShoppingRepository//:IRepository<TblShopping>
    {
        void AddShop(int customerId, List<ShoppingCart> shoppingCart);

        void SaveDetails(int customerId, List<ShoppingCart> shoppingCart);

        void InventoryUpdate(int customerId, List<ShoppingCart> shoppingCart);
    }
}
