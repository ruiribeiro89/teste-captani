using Microsoft.Extensions.DependencyInjection;
using SorteiosBFF.Domain.Interfaces;
using SorteiosBFF.Infrastructure.Repositories;

namespace SorteiosBFF.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISorteioRepository, SorteioRepository>();

            return services;
        }
    }
}
