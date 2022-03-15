using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoppingFreely.BLL.Abstract;
using ShoppingFreely.BLL.Concrete;
using ShoppingFreely.DAL.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.BLL.Dependencies
{
    public static class BLLDependencies
    {
        public static IServiceCollection AddBLLDependencies(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddEFCoreDataAccessDependencies(configuration);
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IListService, ListService>();
            services.AddScoped<IListProductDetailService, ListProductDetailService>();

            return services;
        }
    }
}
