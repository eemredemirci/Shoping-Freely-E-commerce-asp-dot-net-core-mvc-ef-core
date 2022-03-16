

namespace ShoppingFreelyMVC.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
