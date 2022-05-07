namespace Application.Commands.Guild.Commands;

using MediatR;

public class AddGuildCommand : IRequest
{
    public string Name { get; set; }
}
