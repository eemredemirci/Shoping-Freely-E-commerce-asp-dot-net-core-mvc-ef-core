using ShoppingFreely.Core.DAL;
using ShoppingFreely.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.DAL.Abstract
{
    // DAL ve BLL katmanına erişeceğiz
    // Burada kurallar işletildikten sonra Veritabanına erişmek isteyeceğiz
    // Bundan DAL sorumlu olduğu için DAL'a erişecek
    // DAL'a giderken işi yapacak olan Conrete'deki class'a erişmek gerekli
    // Direk bu class'ı kullanırsa bağımlı kalmış olacak
    // Bağımlılığı kaldırmak için her entity'e interface tanımlanır
    // Farklı ORM kullanırken yine IUserRepository kullanabilir
    public interface IUserRepository : IRepository<User>
    {
        // User'a özel bir operasyon varsa burada tanımlanır
    }
}
