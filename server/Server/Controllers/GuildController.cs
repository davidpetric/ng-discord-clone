namespace Api.Controllers;
using Application.Commands.Guild.Commands;
using Infrastucture.Queries.Guild.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class GuildController : Controller
{
    private readonly IMediator mediator;

    public GuildController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetGuilds()
    {
        var guilds = await mediator.Send(new GetUserGuildsQuery());

        return Ok(guilds);
    }

    [HttpPost]
    public async Task<IActionResult> AddGuildAsync(AddGuildCommand guild)
    {
        var addGuildResponse = await mediator.Send(guild);

        return Ok(addGuildResponse);
    }
}
