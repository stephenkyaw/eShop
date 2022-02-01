using eShop.Core.Entities;


namespace eShop.Service.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetProductsAsync();

        public Task<Product> GetProductByIdAsync(Guid id);

        public Task Add(Product product);

    }
}
