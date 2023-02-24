namespace Unwired.Models.ViewModels;

[Obsolete("Use the struct UBaseListViewModel")]
public abstract class BaseListViewModel
{
    public Guid Id { get; set; }
    public Guid? AccountId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}
