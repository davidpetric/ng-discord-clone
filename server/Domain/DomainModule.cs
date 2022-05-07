namespace Domain;
using Domain.Repositories.Guild;
using Microsoft.Extensions.DependencyInjection;
using Shared.Abstractions;

public static class DomainModule
{
    public static IServiceCollection RegisterDomainModule(this IServiceCollection services)
    {
        var repositories = typeof(IGuildRepository).Assembly.GetTypes()
            .Where(x => !x.IsAbstract && x.IsClass && x.GetInterface(nameof(IRepository)) == typeof(IRepository));

        foreach (var repository in repositories)
        {
            services.Add(new ServiceDescriptor(typeof(IRepository), repository, ServiceLifetime.Transient));
        }

        return services;
    }

}