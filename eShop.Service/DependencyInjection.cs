using Microsoft.Extensions.DependencyInjection;

namespace eShop.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddTransient<IProductService, ProductService>();

            return services;
        }
    }
}
