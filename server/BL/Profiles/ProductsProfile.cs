using AutoMapper;
using common;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Profiles
{
    public class ProductsProfile:Profile
    {
        public ProductsProfile()
        {
            CreateMap<TblProducts, ProductsVM>().ReverseMap();
        }
    }
}
