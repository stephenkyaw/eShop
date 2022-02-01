
namespace eShop.Core.Entities
{
    public class Variant : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public string Name { get; set; }
        public List<VariantOption> Options { get; set; } = new List<VariantOption>();
    }
}
