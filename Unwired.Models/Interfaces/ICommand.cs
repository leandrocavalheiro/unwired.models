using MediatR;
using Unwired.Models.BusModels;

namespace Unwired.Models.Interfaces;

public interface ICommand : IRequest<bool>
{
}

public interface ICommand<TResponse> : IRequest<CommandResult<TResponse>>
{
}