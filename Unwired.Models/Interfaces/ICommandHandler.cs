using MediatR;
using Unwired.Models.BusModels;

namespace Unwired.Models.Interfaces;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, bool> where TCommand: ICommand
{
}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, CommandResult<TResponse>> where TCommand : ICommand<TResponse>
{
}
