using eShop.Core.IRpositories;
using eShop.Infrastructure.EfRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(c =>
                c.UseSqlServer(configuration.GetConnectionString("DBCS"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
                ,ServiceLifetime.Scoped);

            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
