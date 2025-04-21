using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Productc.Application.Abstractions;
using Productc.Infrastructure.Persistense;
using Microsoft.EntityFrameworkCore;

namespace Productc.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("LocalConnection"));
            });

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            return services;
        }
    }
}
