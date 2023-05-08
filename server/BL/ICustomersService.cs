using common;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface ICustomersService
    {     
        List<CustomersVM> Add(CustomersVM cstmr1);

        bool Check(string name, string password);
    }
}
