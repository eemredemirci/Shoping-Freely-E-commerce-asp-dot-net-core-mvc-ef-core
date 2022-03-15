using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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

            return services;
        }
    }
}
