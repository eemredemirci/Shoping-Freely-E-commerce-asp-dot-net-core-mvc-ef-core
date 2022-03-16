using Microsoft.EntityFrameworkCore;
using ShoppingFreely.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.Core.DAL.EFCore
{
    public class EFCoreRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity
        where TContext: DbContext/*, new()*/
    {
        // using le new leyerek değil DI ile kullandık
        // Transient ise kullanım using(new()) ile kullanılır
        // Scope ve Singleton DI tercih edilebilir 
        // Ekledikten sonra Getir yapıyorsak
        // Ram'de kaldığı için ihtiyacımız olabilir

        TContext _context;
        DbSet<TEntity> entities;

        public EFCoreRepositoryBase(TContext context)
        {
            _context = context;
            entities = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
            _context.SaveChanges();


            //using (TContext context = new TContext())
            //{
            //    context.Set<TEntity>().Add(entity);
            //}
        }

        public void Delete(TEntity entity)
        {
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return entities.ToList();
                // return _context.Set<TEntity>().ToList(); // bu da olur
            }
            else
            {
                return entities.Where(filter).ToList();
                //return _context.Set<TEntity>().Where(filter).ToList(); // bu da olur
            }
        }

        public TEntity GetById(int id)
        {
            return entities.Find(id);
        }

        public TEntity GetEntity(Expression<Func<TEntity, bool>> filter)
        {
            return entities.SingleOrDefault(filter);
        }

        public void Update(TEntity entity)
        {
            entities.Update(entity);
            _context.SaveChanges();
        }

        //public bool Update(TEntity entity)
        //{
        //    entities.Update(entity);
        //    return _context.SaveChanges() > 0; SaveChanges metodu etkilenen satır sayısını döner
        //}
    }
}
