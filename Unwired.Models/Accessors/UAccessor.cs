using Unwired.Models.Interfaces;

namespace Unwired.Models.Accessors;

public class UAccessor : IUAccessor
{
    public Guid? TenantId { get; set; }
    public Guid? AccountId { get; set; }
    public Guid? UserId { get; set; }
    public string Language { get; set; }
    public string TimeZone { get; set; }
    public UAccessor()
    {
        Language = "pt-br";
        TimeZone = "GMT+0";
    }
}
