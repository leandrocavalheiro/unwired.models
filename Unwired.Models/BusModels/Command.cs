using Unwired.Models.Interfaces;

namespace Unwired.Models.BusModels;

public abstract class Command : ICommand
{
}

public abstract class Command<TResponse> : ICommand<TResponse>
{
}