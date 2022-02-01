using eShop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Variant> Variants { get; set; }

        public DbSet<VariantOption> VariantOptions { get; set; }
    }
}
