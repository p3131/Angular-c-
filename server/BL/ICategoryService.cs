using common;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface ICategoryService : IService<CategoryVM>
    {
        CategoryVM GetById(int id);
                                                 
        List<CategoryVM> GetAll();

        List<CategoryVM> Delete(int id);

        void Update(CategoryVM ctgry2);

        //void Add(CategoryVM ctgry1);
    }
}
