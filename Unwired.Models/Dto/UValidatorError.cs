namespace Unwired.Models.Dto;

public struct UValidationError
{
    public string PropertyName { get; set; }
    public string ErrorMessage { get; set; }
    public string ErrorCode { get; set; }
    public UValidationError(string propertyName, string errorMessage, string errorCode)
    {
        PropertyName = propertyName;
        ErrorMessage = errorMessage;
        ErrorCode = errorCode;
    }
}