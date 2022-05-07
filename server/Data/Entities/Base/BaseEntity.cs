using ApplicationCore.Entities.Interfaces;

namespace ApplicationCore.Entities.Base;

public class BaseEntity : IEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}