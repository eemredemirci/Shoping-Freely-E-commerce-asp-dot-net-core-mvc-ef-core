
using ShoppingFreelyMVC.Models.Authentication;
using System.ComponentModel.DataAnnotations;

namespace ShoppingFreelyMVC.Models
{
    public class ShoppingList : BaseEntity
    {
        public ShoppingList()
        {
            ShopingListDetails = new HashSet<ShopingListDetail>();
            Users = new HashSet<User>();
        }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        public ListStatus? Status { get; set; } = ListStatus.Open;
        public string? ShopperUser { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<ShopingListDetail> ShopingListDetails { get; set; }
    }
}
