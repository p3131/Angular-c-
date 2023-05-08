using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection addRepositories(this IServiceCollection serviceCollection, IConfiguration config)
        {
            serviceCollection.AddScoped<ICategoryRepository, CategoryRepository>();
            serviceCollection.AddScoped<IProductsRepository, ProductsRepository>();
            serviceCollection.AddScoped<ICustomersRepository, CustomersRepository>();
            serviceCollection.AddScoped<IShoppingRepository, ShoppingRepository>();
            //added as scoped service
            serviceCollection.AddDbContext<clothingstore1Context>(opt => opt.UseSqlServer(config.GetConnectionString("ClothingStore")));
            return serviceCollection;
        }
    }
}
