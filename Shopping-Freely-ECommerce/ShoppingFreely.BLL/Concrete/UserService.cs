using ShoppingFreely.BLL.Abstract;
using ShoppingFreely.DAL.Abstract;
using ShoppingFreely.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.BLL.Concrete
{
    internal class UserService : IUserService
    {
        // IUserRepository üzerinden ulaşmalı EFCoreRepository'e
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Mobil yada farklı uygulama yapınca yeniden kural yazmak yerine burada kural tanımlanır
        public void Add(User entity)
        {
            if(entity.Password.Length<8)
            {
                // farklı tipten geri dönüş olabilir
                throw new Exception("Şifreniz en az 8 karakter olmalıdır");
            }
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public User GetEntity(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
