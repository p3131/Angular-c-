using common;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface IProductsService : IService<ProductsVM>
    {
        ProductsVM GetById(int id);

        List<ProductsVM> GetByIdCategory(int idCategory);

        List<ProductsVM> GetAll();

        void Delete(int id);

        void Update(ProductsVM ctgry2);

        //void Add(ProductsVM ctgry1);
    }
}
