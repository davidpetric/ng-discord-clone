namespace Infrastucture.Queries.Guild.Queries;
using Infrastucture.Queries.Guild.Handlers;
using MediatR;

using Guild = Domain.Entities.Guild;

public class GetUserGuildsQueryHandler : IRequestHandler<GetUserGuildsQuery, IEnumerable<Guild>>
{
    public Task<IEnumerable<Guild>> Handle(GetUserGuildsQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(Enumerable.Empty<Guild>());
    }
}
