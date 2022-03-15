
namespace ShoppingFreely.Core.Entities
{
    // farklı tür Id gelirse kullanılır
    internal interface IKey<TKey>
    {
        public TKey ID { get; set; }

    }
}
