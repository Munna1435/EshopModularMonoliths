using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering
{
    public static class OrderingModule
    {
        public static IServiceCollection AddOrderingModule(this IServiceCollection service, IConfiguration configuration)
        {
            return service;
        }

        public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
