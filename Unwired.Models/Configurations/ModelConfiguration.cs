using Microsoft.Extensions.DependencyInjection;
using Unwired.Models.Accessors;
using Unwired.Models.Interfaces;

namespace Unwired.Models.Configurations;

public static class ModelConfiguration
{
    public static void AddUnwiredModels(this IServiceCollection services)
    {
        // Custom MediatR               
        services.AddScoped<IUnwiredAccessor, UnwiredAccessor>();
        services.AddScoped<IUAccessor, UAccessor>();
    }
}
