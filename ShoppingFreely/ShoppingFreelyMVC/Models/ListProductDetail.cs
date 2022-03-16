

namespace ShoppingFreelyMVC.Models
{
    public class ListProductDetail : BaseEntity
    {
        public int ListId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public ShopingList List { get; set; }
        public Product Product { get; set; }
    }
}
