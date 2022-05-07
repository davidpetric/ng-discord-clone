namespace Infrastucture;

using Infrastucture.Context;
using Infrastucture.Queries.Guild.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class InfrastuctureModule
{
    public static IServiceCollection RegisterInfrastuctureModule(this IServiceCollection services)
    {
        services.AddMediatR(typeof(GetUserGuildsQueryHandler).Assembly);

        var serviceProvider = services.BuildServiceProvider();
        var config = serviceProvider.GetService<IConfiguration>();

        string connectionString = config["ConnectionString:DiscordDbClone"];
        services.AddDbContext<DiscordDbContext>(x => x.UseSqlServer(connectionString));
        return services;
    }
}
