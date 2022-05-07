namespace Infrastucture.Queries.Guild.Handlers;
using MediatR;

public class GetUserGuildsQuery : IRequest<IEnumerable<Domain.Entities.Guild>>
{
}
