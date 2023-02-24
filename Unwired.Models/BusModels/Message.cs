namespace Unwired.Models.BusModels;

public abstract class Message
{
    public string MessageType { get; private set; }
    public Guid AggregateId { get; protected set; }
    public DateTime Timestamp { get; private set; }

    protected Message()
    {
        MessageType = GetType().Name;
        Timestamp = DateTime.UtcNow;
        DateTime.SpecifyKind(Timestamp, DateTimeKind.Utc);
    }
}
