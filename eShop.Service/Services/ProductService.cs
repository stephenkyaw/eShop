using eShop.Core.Entities;
using eShop.Core.IRpositories;

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

            await _repository.SaveChangesAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _repository.GetEntityById(id);
        }

        public async Task<IEnumerable<Product>> GetProductsByCodeAsync(string code)
        {
            return await _repository.GetAllByCodeAsync(code);
        }
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _repository.GetAll();
        }
    }
}
