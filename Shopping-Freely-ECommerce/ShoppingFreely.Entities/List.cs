using ShoppingFreely.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.Entities
{
    public class List : BaseEntity
    {
        public List()
        {
            Products = new HashSet<Product>();
            Users = new HashSet<User>();
        }
        public string Name { get; set; }
        public ListStatus Status { get; set; } = ListStatus.Open;
        public int UserId { get; set; }
        public User UserManager { get; set; }
        public User User { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
