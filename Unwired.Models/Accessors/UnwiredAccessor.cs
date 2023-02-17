using Unwired.Models.Interfaces;

namespace Unwired.Models.Accessors;

public class UnwiredAccessor : IUnwiredAccessor
{
    public Guid? TenantId { get; set; }
    public Guid? AccountId { get; set; }
    public Guid? UserId { get; set; }
    public string Language { get; set; }
    public string TimeZone { get; set; }
    public UnwiredAccessor()
    {
        Language = "pt-br";
        TimeZone = "GMT+0";
    }
}
