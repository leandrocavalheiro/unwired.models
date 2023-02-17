namespace Unwired.Models.Dto;

public struct ValidationError
{
    public string PropertyName { get; set; }
    public string ErrorMessage { get; set; }
    public string ErrorCode { get; set; }
    public ValidationError(string propertyName, string errorMessage, string errorCode)
    {
        PropertyName = propertyName;
        ErrorMessage = errorMessage;
        ErrorCode = errorCode;
    }
}