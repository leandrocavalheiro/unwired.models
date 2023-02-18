using System.Text.Json.Serialization;
using Unwired.Models.Dto;

namespace Unwired.Models.CustomJsonSerializerContext;

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true)]
[JsonSerializable(typeof(IEnumerable<Notification>))]
[JsonSerializable(typeof(ICollection<Notification>))]
[JsonSerializable(typeof(IList<Notification>))]
[JsonSerializable(typeof(Notification))]

[JsonSerializable(typeof(IEnumerable<UNotification>))]
[JsonSerializable(typeof(ICollection<UNotification>))]
[JsonSerializable(typeof(IList<UNotification>))]
[JsonSerializable(typeof(UNotification))]
public partial class CustomJsonContext : JsonSerializerContext
{
}
