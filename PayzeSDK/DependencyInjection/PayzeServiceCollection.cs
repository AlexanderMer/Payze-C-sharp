using Microsoft.Extensions.DependencyInjection;
using PayzeSDK.Payments;

namespace PayzeSDK
{
    public static class PayzeServiceCollection
    {
        public static IServiceCollection AddPayzeSDK(this IServiceCollection services, ApiKey options)
        {
            services.AddSingleton(options);
            services.AddScoped<IPayzeClient, PayzeClient>();
            return services;
        }
    }
}
