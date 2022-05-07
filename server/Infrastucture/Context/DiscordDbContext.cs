namespace Infrastucture.Context;

using Microsoft.EntityFrameworkCore;

public class DiscordDbContext : DbContext
{
    public DiscordDbContext(
        DbContextOptions<DiscordDbContext> optionsBuilder)
        : base(optionsBuilder)
    {

    }
}
