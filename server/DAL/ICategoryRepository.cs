using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICategoryRepository:IRepository<TblCategory>
    {
        List<TblCategory> DeleteCategory(int id);
        void UpdateCategory(TblCategory ctgry2);
        void AddCategory(TblCategory ctgry1);
        TblCategory GetById(int id);
    }
}
