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
    internal class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Add(Product entity)
        {
            //admin
            _productRepository.Add(entity);
        }

        public void Delete(Product entity)
        {
            entity.IsActive = false;
            _productRepository.Update(entity);
        }

        public ICollection<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _productRepository.GetAll(filter);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product GetEntity(Expression<Func<Product, bool>> filter)
        {
            return _productRepository.GetEntity(filter);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
