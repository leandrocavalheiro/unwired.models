namespace Unwired.Models.ViewModels;

[Obsolete("Use the struct UBaseViewModel")]
public abstract class BaseViewModel
{
    public Guid Id { get; set; }
    public Guid? AccountId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletadAt { get; set; }
}
