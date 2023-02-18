using Unwired.Models.Dto;

namespace Unwired.Models.ViewModels;

[Obsolete("Use the struct UErrorViewModel")]
public struct ErrorViewModel
{
    public Notification[] Error { get; set; }

    public ErrorViewModel(IEnumerable<Notification> errors)
    {
        Error = errors.ToArray();
    }

    public ErrorViewModel(Notification errors)
    {
        Error = new[] { errors };
    }
}
