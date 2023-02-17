using Microsoft.Extensions.DependencyInjection;
using Unwired.Models.Accessors;
using Unwired.Models.Interfaces;

namespace Unwired.Models.Configurations;

public static class ModelConfiguration
{
    public static void AddUnwiredModels(this IServiceCollection services)
    {
        services.AddScoped<IUnwiredAccessor, UnwiredAccessor>();
    }
}
