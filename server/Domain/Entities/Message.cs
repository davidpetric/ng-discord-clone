using Domain.Entities.Base;

namespace Domain.Entities;

public class Message : BaseEntity
{
    public string Content { get; set; }
    public Guid EntityId { get; set; }
    public Guid EntityTypeId { get; set; }
    public bool IsDeleted { get; set; }
    public Guid? ReplayingToUserId { get; set; }
    public User Author { get; set; }
    public Guid AuthorId { get; set; }
}
