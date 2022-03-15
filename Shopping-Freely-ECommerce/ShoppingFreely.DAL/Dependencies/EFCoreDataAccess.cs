using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoppingFreely.DAL.Abstract;
using ShoppingFreely.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.DAL.Dependencies
{
    public static class EFCoreDataAccess
    {
        public static IServiceCollection AddEFCoreDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShoppingFreelyDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ShoppingFreelyDb")));
            services.AddScoped<IUserRepository, EFCoreUserRepository>();
            //services.AddScoped<ITaskRepository, EFTaskRepository>();

            return services;
        }

    }
}
