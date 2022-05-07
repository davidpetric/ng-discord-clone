namespace Application;
using Application.Commands.Guild.Handlers;
using Application.Profiles;
using AutoMapper;
using MediatR;

using Microsoft.Extensions.DependencyInjection;

public static class Module
{
    public static IServiceCollection RegisterApplicationModule(this IServiceCollection services)
    {
        services.AddMediatR(typeof(AddGuildCommandHandler).Assembly);

        var automapperConfig = new MapperConfiguration(cfg => cfg.AddMaps(typeof(GuildProfile).Assembly));

        return services;
    }
}
