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
            _userRepository.Add(entity);
        }

        public void Delete(User entity)
        {
            entity.IsActive = false;
            _userRepository.Update(entity);
        }

        public ICollection<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _userRepository.GetAll(filter);
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User GetEntity(Expression<Func<User, bool>> filter)
        {
            return _userRepository.GetEntity(filter);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }
    }
}
