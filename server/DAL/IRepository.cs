using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
    }
}
