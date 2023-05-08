using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IProductsRepository:IRepository<TblProducts>
    {
        void DeleteProducts(int id);
        void UpdateProducts(TblProducts ctgry2);
        void AddProducts(TblProducts ctgry1);
        List<TblProducts> GetByIdCategory(int idCategory);
    }
}
