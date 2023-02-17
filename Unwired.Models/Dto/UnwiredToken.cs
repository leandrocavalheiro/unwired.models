namespace Unwired.Models.Dto;

public struct UnwiredToken
{
    public string Secret { get; set; }
    public uint ExpiresInMinutes { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }    
}
