using JobTracker.Application.Common.Interfaces;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

namespace JobTracker.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
            return services;
        }

    }
}
