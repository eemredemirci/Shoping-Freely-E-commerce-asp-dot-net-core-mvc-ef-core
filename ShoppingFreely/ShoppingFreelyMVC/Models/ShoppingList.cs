
using ShoppingFreelyMVC.Models.Authentication;

namespace ShoppingFreelyMVC.Models
{
    public class ShoppingList : BaseEntity
    {
        public ShoppingList()
        {
            Products = new HashSet<Product>();
            Users = new HashSet<User>();
        }
        public string Name { get; set; }
        public ListStatus Status { get; set; } = ListStatus.Open;
        public string AdminId { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
