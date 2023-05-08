using AutoMapper;
using common;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Profiles
{
    public class CustomersProfile:Profile
    {
        public CustomersProfile()
        {
            CreateMap<TblCustomers, CustomersVM>().ReverseMap();
        }
    }
}
