namespace Unwired.Models.ViewModels;

public struct TokenResultViewModel
{
    public Guid UserId { get; set; }
    public string AccessToken { get; set; }
    public string TokenType { get; set; }
    public DateTime ExpiresAt { get; set; }
}
