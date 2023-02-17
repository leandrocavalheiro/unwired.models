using System.Text.Json.Serialization;
using Unwired.Models.Dto;

namespace Unwired.Models.CustomJsonSerializerContext;

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true)]
[JsonSerializable(typeof(IEnumerable<Notification>))]
[JsonSerializable(typeof(ICollection<Notification>))]
[JsonSerializable(typeof(IList<Notification>))]
[JsonSerializable(typeof(Notification))]
public partial class CustomJsonContext : JsonSerializerContext
{
}
