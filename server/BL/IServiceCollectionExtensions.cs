using AutoMapper;
using BL.Profiles;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection addServices(this IServiceCollection serviceCollection, IConfiguration config)
        {
            serviceCollection.AddScoped<ICategoryService, CategoryService>();
            serviceCollection.AddScoped<IProductsService, ProductsService>();
            serviceCollection.AddScoped<ICustomersService, CustomersService>();
            serviceCollection.AddScoped<IShoppingService, ShoppingService>();
            serviceCollection.AddAutoMapper(typeof(CategoryProfile));
            serviceCollection.AddAutoMapper(typeof(ProductsProfile));
            serviceCollection.AddAutoMapper(typeof(CustomersProfile));
            serviceCollection.addRepositories(config);    //קריאה-קשר בין השכבות
            return serviceCollection;
        }
    }
}
