

namespace ShoppingFreelyMVC.Models
{
    public class Product : BaseEntity
    {
        public Product()
        {
            ShopingListDetails = new HashSet<ShopingListDetail>();
                }
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ShopingListDetail> ShopingListDetails { get; set; }

    }
}
