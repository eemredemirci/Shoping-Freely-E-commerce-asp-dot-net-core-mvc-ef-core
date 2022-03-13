using ShoppingFreely.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
