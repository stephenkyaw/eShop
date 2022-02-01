using eShop.Core.Entities;
using eShop.Core.IRpositories;
using eShop.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.EfRepositories
{
    public class ProductRepository : EfBaseRepository<Product>, IProductRepository
    {

        public ProductRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Product>> GetAllByCodeAsync(string code)
        {
            return await _context.Products.Where(x => x.Code == code).ToListAsync();
        }
    }
}
