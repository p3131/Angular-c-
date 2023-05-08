using System;
using System.Collections.Generic;
using AutoMapper;
using common;
using DAL;
using server.DBModels;

namespace BL
{
    public class CustomersService : ICustomersService
    {
        private ICustomersRepository repo;
        IMapper mapper;

        public CustomersService(ICustomersRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }


        public List<CustomersVM> Add(CustomersVM cstmr1)
        {
            TblCustomers cstmr2 = mapper.Map<TblCustomers>(cstmr1);
            List<TblCustomers> tc = repo.AddCustomers(cstmr2);
            List<CustomersVM> cas = mapper.Map<List<CustomersVM>>(tc);
            return cas;
        }

        public bool Check(string name, string password)
        {
            return repo.Check(name, password);
        }
    }
}
