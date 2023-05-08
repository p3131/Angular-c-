using System;
using System.Collections.Generic;
using common;
using DAL;
using DAL.DBModels_;
using server.DBModels;

namespace BL
{
    public class ShoppingService : IShoppingService
    {
        private IShoppingRepository repo;

        public ShoppingService(IShoppingRepository repo)
        {
            this.repo = repo;
        }

        public void AddShop(int customerId, List<ShoppingCart> shoppingCart)
        {
            repo.AddShop(customerId, shoppingCart);
            repo.SaveDetails(customerId, shoppingCart);
            repo.InventoryUpdate(customerId, shoppingCart);
        }
    }
}
