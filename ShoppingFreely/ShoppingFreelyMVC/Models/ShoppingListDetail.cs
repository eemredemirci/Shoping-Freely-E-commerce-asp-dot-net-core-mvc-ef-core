

namespace ShoppingFreelyMVC.Models
{
    public class ShopingListDetail : BaseEntity
    {
        public int ShoppingListId { get; set; }
        public int ProductId { get; set; }
        public ListDetailUnit? Unit { get; set; } = ListDetailUnit.Tane;
        public int? Quantity { get; set; }
        public string? Brand { get; set; } = "Farketmez";
        public string? Description { get; set; }
        public ShoppingList ShoppingList { get; set; }
        public Product Product { get; set; }
    }
}
