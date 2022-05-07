namespace Application.Commands.Guild.Handlers;
using Application.Commands.Guild.Commands;

using MediatR;

public class AddGuildCommandHandler : IRequestHandler<AddGuildCommand>
{
    public Task<Unit> Handle(AddGuildCommand request, CancellationToken cancellationToken)
    {
        return Unit.Task;
    }
}
