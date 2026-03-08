using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket
{
    public static class BasketModule
    {
        public static IServiceCollection AddBasketModule(this IServiceCollection service, IConfiguration configuration)
        {
            return service;
        }

        public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
