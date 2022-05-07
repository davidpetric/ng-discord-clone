using ApplicationCore.Entities.Base;

namespace ApplicationCore.Entities;

public class GuildChannel : BaseEntity
{
    public string Name { get; set; }

    public Guid GuildId { get; set; }

    public Guild Guild { get; set; }

    public List<Message> Messages { get; set; } = new List<Message>();
    //public List<User> Members { get; set; } = new List<User>();
}
