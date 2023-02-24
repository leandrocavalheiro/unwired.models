using MediatR;

namespace Unwired.Models.Interfaces;

public interface IQuery<TResponse> : IRequest<TResponse>
{
}