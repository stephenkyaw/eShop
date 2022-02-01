using eShop.Core.Entities;
using eShop.Core.IRpositories;
using eShop.Service.Interfaces;

namespace eShop.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(Product product)
        {
            await _repository.AddAsync(product);
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id.ToString());
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
