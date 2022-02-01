

namespace eShop.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public List<Variant> Variants { get; set; } = new List<Variant>();
    }
}
