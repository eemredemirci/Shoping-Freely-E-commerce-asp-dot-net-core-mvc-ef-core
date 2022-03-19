
using ShoppingFreelyMVC.Models.Authentication;
using System.ComponentModel.DataAnnotations;

namespace ShoppingFreelyMVC.Models
{
    public class ShoppingList : BaseEntity
    {
        public ShoppingList()
        {
            Products = new HashSet<Product>();
            Users = new HashSet<User>();
        }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        public ListStatus? Status { get; set; } = ListStatus.Open;
        public string? AdminId { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
