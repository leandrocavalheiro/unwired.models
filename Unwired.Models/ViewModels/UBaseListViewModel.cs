namespace Unwired.Models.ViewModels;

public abstract class UBaseListViewModel
{
    public Guid Id { get; set; }
    public Guid? AccountId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}
