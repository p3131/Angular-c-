using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using server.DBModels;

namespace DAL
{
    class ProductsRepository : IProductsRepository
    {
        clothingstore1Context context;

        public ProductsRepository(clothingstore1Context context)
        {
            this.context = context;
        }

        public void AddProducts(TblProducts ctgry1)
        {
            context.TblProducts.Add(ctgry1);
            context.SaveChanges();
        }

        public void DeleteProducts(int id)
        {
            context.TblProducts.Remove(context.TblProducts.FirstOrDefault(c => c.ProductId == id));
            context.SaveChanges();
        }

        public List<TblProducts> GetAll()
        {
            return context.TblProducts.ToList();
        }

        public TblProducts GetById(int id)
        {
            return context.TblProducts.First(c => c.ProductId == id);
        }

        public List<TblProducts> GetByIdCategory(int idCategory)
        {
            return context.TblProducts.Where(c => c.CategoryId == idCategory).ToList();
        }

        public void UpdateProducts(TblProducts ctgry2)
        {
            context.TblProducts.Update(ctgry2);
            context.SaveChanges();
        }
    }
}
