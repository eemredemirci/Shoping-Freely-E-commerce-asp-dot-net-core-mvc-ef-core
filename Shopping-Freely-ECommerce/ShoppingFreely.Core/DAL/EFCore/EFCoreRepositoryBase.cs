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

        readonly TContext _context;
        readonly DbSet<TEntity> _dbSet;
        public EFCoreRepositoryBase(TContext context)
        {
            _context = context;
            _dbSet=_context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if(filter==null)
            {
                return _dbSet.ToList();
                //return _context.Set<TEntity>().ToList();
            }
            else
            {
                return _dbSet.Where(filter).ToList();
                //return _context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetEntity(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
