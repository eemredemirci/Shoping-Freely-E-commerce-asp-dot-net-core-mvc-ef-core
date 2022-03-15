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
    internal class ListService : IListService
    {
        private readonly IListRepository _listRepository;
        public ListService(IListRepository listRepository)
        {
            _listRepository = listRepository;
        }
        public void Add(List entity)
        {
            _listRepository.Add(entity);
        }

        public void Delete(List entity)
        {
            // sadece sahibi siler
            entity.IsActive = false;
            _listRepository.Update(entity);
        }

        public ICollection<List> GetAll(Expression<Func<List, bool>> filter = null)
        {
            return _listRepository.GetAll(filter);

        }

        public List GetById(int id)
        {
            return _listRepository.GetById(id);
        }

        public List GetEntity(Expression<Func<List, bool>> filter)
        {
            return _listRepository.GetEntity(filter);
        }

        public void Update(List entity)
        {
            // eğer status alışverişe çıkıyorum değilse
            _listRepository.Update(entity);
        }
    }
}
