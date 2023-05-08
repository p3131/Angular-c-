using DAL.DBModels_;
using Microsoft.EntityFrameworkCore;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ShoppingRepository:IShoppingRepository
    {
        clothingstore1Context context;

        public ShoppingRepository(clothingstore1Context context)
        {
            this.context = context;
        }

        public void AddShop(int customerId, List<ShoppingCart> shoppingCart)
        {
            foreach (var item in shoppingCart)
            {
                TblShopping tsh = new TblShopping
                {
                    //ShoppingId = 0,
                    CustomerId = customerId,
                    ShopDate = DateTime.Now,
                    AmountToPay = item.FinalPrice
                };
                context.TblShopping.Add(tsh);
                context.SaveChanges();
            }
        }

        public void SaveDetails(int customerId, List<ShoppingCart> shoppingCart)
        {
            foreach (var item in shoppingCart)
            {            
                TblShopDetails tsh = new TblShopDetails
                {
                    ShoppingId = context.TblShopping.Max(sh=>sh.ShoppingId),
                    ProductId = item.ProductId,
                    Quantity=item.Quantity
                };
            
                context.TblShopDetails.Add(tsh);
                context.SaveChanges();
            }
        }

        public void InventoryUpdate(int customerId, List<ShoppingCart> shoppingCart)
        {
            foreach (var item in shoppingCart)
            {
                TblProducts prod = context.TblProducts.First(p => p.ProductId == item.ProductId);
                if (prod == null)
                    return;
                if (prod.QuantityInStock > item.Quantity)   //האם להשאיר אופציה שישאר מוצר שאין ממנו במלאי או שלמחוק אותו לגמרי?
                {
                    prod.QuantityInStock -= item.Quantity;
                    context.TblProducts.Update(prod);
                    context.SaveChanges();
                    return;
                }
                context.TblProducts.Remove(context.TblProducts.First(p => p == prod));
                context.SaveChanges();
            }
        }
    }
}