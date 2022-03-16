using ShoppingFreely.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.Core.DAL
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity // veya where TEntity : IEntity
    {
        // Add, Update, Delete metotlarını bool dönecek şekilde de yapabiliriz. İşlem başarılı mı değil mi bilgisini dönmek için
        // Task async de üretebilirsin
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int id);
        TEntity GetEntity(Expression<Func<TEntity, bool>> filter);
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

    }
}
