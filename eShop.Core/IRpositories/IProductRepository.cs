namespace eShop.Core.IRpositories
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetAllAsync();

        public Task<Product> GetByIdAsync(string id);

        public Task AddAsync(Product product);
    }
}
