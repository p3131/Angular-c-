using common;
using Microsoft.EntityFrameworkCore;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CategoryRepository:ICategoryRepository
    {
        clothingstore1Context context;

        public CategoryRepository(clothingstore1Context context)
        {
            this.context = context;
        }

        public List<TblCategory> GetAll()
        {
            return context.TblCategory.ToList();
        }

        public TblCategory GetById(int id)
        {
            return context.TblCategory.First(c => c.CategoryId == id);
        }

        public List<TblCategory> DeleteCategory(int id)
        {
            context.TblCategory.Remove(context.TblCategory.FirstOrDefault(c=>c.CategoryId==id));
            context.SaveChanges();
            return GetAll();
        }

        public void UpdateCategory(TblCategory ctgry2)
        {
            context.TblCategory.Update(ctgry2);
            context.SaveChanges();
        }

        public void AddCategory(TblCategory ctgry1)
        {
            context.TblCategory.Add(ctgry1);
            context.SaveChanges();
        }

    }
}