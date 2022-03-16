using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.Core.BLL
{
    // BLL'deki iş süreçlerini tanımladığı için IRepository'den kalıtımla aşağıdaki 5 operasyonu almak yanlış olur
    // Örneğin Add kullanırken kural kontrolü burada yapılır
    // Operasyon kuralları burada işletilir
    // Örneğin veritabanından bolean döndürdük ama burda aynı olmayabilir
    public interface IService<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int id);
        TEntity GetEntity(Expression<Func<TEntity, bool>> filter);
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

        ////Task
        //Task<TEntity> GetByIdAsync(int id);
        //Task AddAsync(TEntity entity);
        //Task UpdateAsync(TEntity entity);
        //Task DeleteAsync(TEntity entity);

    }
}
