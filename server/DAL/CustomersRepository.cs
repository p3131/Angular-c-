using Microsoft.EntityFrameworkCore;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CustomersRepository : ICustomersRepository
    {
        clothingstore1Context context;

        public CustomersRepository(clothingstore1Context context)
        {
            this.context = context;
        }

        public List<TblCustomers> AddCustomers(TblCustomers cstmr1)
        {
            context.TblCustomers.Add(cstmr1);
            //context.TblCategory.Entry<string>(ctgry1.CategoryName);
            context.SaveChanges();
            return GetAll();
        }

        public bool Check(string name, string password)
        {
            return context.TblCustomers.FirstOrDefault(c => c.CustomerName == name && c.Password == password)!=null;
        }

        public List<TblCustomers> GetAll()
        {
            return context.TblCustomers.ToList();
        }

        public TblCustomers GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}