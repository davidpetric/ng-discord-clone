using Domain.Entities.Base;
using Domain.Entities.Interfaces;

namespace Domain.Entities;

public class User : BaseEntity, IEntityWithAvatar
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string AvatarUrl { get; set; }
    //public List<Guild> Memberships { get; set; } = new List<Guild>();
    //public List<Guild> GuildOwnerships { get; set; } = new List<Guild>();
    //public List<GuildChannel> ChannelMembers { get; set; } = new List<GuildChannel>();
    public List<Message> Messages { get; set; } = new List<Message>();
}
