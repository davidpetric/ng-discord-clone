namespace Domain.Repositories.Guild;

using Shared.Abstractions;
using Guild = Entities.Guild;

public interface IGuildRepository : IRepository
{
    Task<Guild> Get(Guid id);

    Task Add(Guild guild);

    Task Update(Guild guild);

    Task Delete(Guild guild);
}
