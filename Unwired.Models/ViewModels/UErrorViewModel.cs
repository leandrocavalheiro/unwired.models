using Unwired.Models.Dto;
namespace Unwired.Models.ViewModels;
public struct UErrorViewModel
{
    public UNotification[] Error { get; set; }

    public UErrorViewModel(IEnumerable<UNotification> errors)
    {
        Error = errors.ToArray();
    }

    public UErrorViewModel(UNotification errors)
    {
        Error = new[] { errors };
    }
}
