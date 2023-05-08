using common;
using DAL.DBModels_;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface IShoppingService
    {
        void AddShop(int customerId, List<ShoppingCart> shoppingCart);
    }
}
