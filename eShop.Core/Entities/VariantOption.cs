namespace eShop.Core.Entities
{
    public class VariantOption : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid VariantId { get;set;}
        public Variant Variant { get; set; }

        public string Option { get; set; }
        public string Sku { get; set; }
        public Decimal Price { get; set; }
    }
}
