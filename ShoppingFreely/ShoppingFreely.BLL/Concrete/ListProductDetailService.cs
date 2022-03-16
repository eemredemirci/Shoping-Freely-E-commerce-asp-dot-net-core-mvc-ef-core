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
    internal class ListProductDetailService : IListProductDetailService
    {
        private readonly IListProductDetailRepository _listProductDetailRepository;
        public ListProductDetailService(IListProductDetailRepository listProductDetailRepository)
        {
           _listProductDetailRepository= listProductDetailRepository;
        }
        public void Add(ListProductDetail entity)
        {
            _listProductDetailRepository.Add(entity);
        }

        public void Delete(ListProductDetail entity)
        {
            entity.IsActive = false;
            _listProductDetailRepository.Update(entity);
        }

        public ICollection<ListProductDetail> GetAll(Expression<Func<ListProductDetail, bool>> filter = null)
        {
            return _listProductDetailRepository.GetAll(filter);
        }

        public ListProductDetail GetById(int id)
        {
            return _listProductDetailRepository.GetById(id);
        }

        public ListProductDetail GetEntity(Expression<Func<ListProductDetail, bool>> filter)
        {
            return _listProductDetailRepository.GetEntity(filter);
        }

        public void Update(ListProductDetail entity)
        {
            _listProductDetailRepository.Update(entity);
        }
    }
}
