namespace eShop.Core.IRpositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        public Task<IEnumerable<Product>> GetAllByCodeAsync(string code);
    }
}
