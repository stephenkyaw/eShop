namespace eShop.Core.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Created { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public byte[] Timestamp { get; set; }
        public bool IsDeleted { get; set; } = true;
    }
}
