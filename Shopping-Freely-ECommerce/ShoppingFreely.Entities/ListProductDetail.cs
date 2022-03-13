using ShoppingFreely.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.Entities
{
    public class ListProductDetail : BaseEntity
    {
        public int ListId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public List List { get; set; }
        public Product Product { get; set; }
    }
}
