namespace Unwired.Models.ViewModels;

[Obsolete("Use the struct UTokenResultViewModel")]
public struct TokenResultViewModel
{
    public Guid UserId { get; set; }
    public string AccessToken { get; set; }
    public string TokenType { get; set; }
    public DateTime ExpiresAt { get; set; }
}
