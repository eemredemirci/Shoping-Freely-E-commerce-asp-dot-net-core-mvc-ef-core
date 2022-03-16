using ShoppingFreely.Core.DAL.EFCore;
using ShoppingFreely.DAL.Abstract;
using ShoppingFreely.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.DAL.Concrete
{
    class EFCoreUserRepository : EFCoreRepositoryBase<User, ShoppingFreelyDbContext>, IUserRepository
    {
        // using li kullanacaksak ctor boş kalabilirdi

        public EFCoreUserRepository(ShoppingFreelyDbContext dbContext) : base(dbContext)
        {

        }
    }
}
