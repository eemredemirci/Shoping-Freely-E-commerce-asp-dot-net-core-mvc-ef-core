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
    internal class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository=categoryRepository;
        }

        public void Add(Category entity)
        {
            //admin
            _categoryRepository.Add(entity);
        }

        public void Delete(Category entity)
        {
            //admin
            entity.IsActive = false;
            _categoryRepository.Update(entity);
        }

        public ICollection<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryRepository.GetAll(filter);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetEntity(Expression<Func<Category, bool>> filter)
        {
            return _categoryRepository.GetEntity(filter);
        }

        public void Update(Category entity)
        {
            //admin
            _categoryRepository.Update(entity);
        }
    }
}
