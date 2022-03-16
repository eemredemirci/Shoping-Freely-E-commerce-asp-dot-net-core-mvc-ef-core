using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.Core.Entities
{
    //Bir sınıfın entity olduğunu işaretlemek için bu interface de kullanılabilir.
    //Generic yazdığımız yerlerde BaseEntity olmalıdır şeklindeki kısıtları da IEntity yapmak gerekir bu durumda.
    //interface IEntity
    //{

    //}

    public abstract class BaseEntity
    {
        //public TKey ID { get; set; } Farklı tiplerde ID olma durumunda bu sınıfı generic yapabilirsiniz ya da IKey interface'ini kullanabilirsiniz.
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
