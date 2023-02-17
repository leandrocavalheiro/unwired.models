namespace Unwired.Models.Interfaces;

public interface IUnwiredAccessor
{
    Guid? AccountId { get; set; }
    Guid? TenantId { get; set; }
    Guid? UserId { get; set; }
    string Language { get; set; }
    string TimeZone { get; set; }
}
