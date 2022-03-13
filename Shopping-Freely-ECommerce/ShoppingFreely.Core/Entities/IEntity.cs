using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
    }
}
