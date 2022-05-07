using ApplicationCore.Entities.Base;
using ApplicationCore.Entities.Interfaces;

namespace ApplicationCore.Entities;

public class Guild : BaseEntity, IEntityWithAvatar
{
    public string Name { get; set; }
    public List<User> Members { get; set; } = new List<User>();
    public User Owner { get; set; }
    public Guid OwnerId { get; set; }
    public string AvatarUrl { get; set; }
    public List<GuildChannel> GuildChannels { get; set; } = new List<GuildChannel>();
}
