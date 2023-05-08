using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICustomersRepository:IRepository<TblCustomers>
    {
        List<TblCustomers> AddCustomers(TblCustomers cstmr1);

        bool Check(string name, string password);
    }
}
