using AutoMapper;
using common;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Profiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<TblCategory, CategoryVM>().ReverseMap();
        }
    }
}
