

namespace ShoppingFreelyMVC.Models
{
    public class ShopingList : BaseEntity
    {
        public ShopingList()
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
