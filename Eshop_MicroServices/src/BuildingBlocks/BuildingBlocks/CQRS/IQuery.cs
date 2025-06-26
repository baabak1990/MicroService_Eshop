using MediatR;

namespace BuildingBlocks.CQRS;
public interface IQuery: IQuery<uint>
{

}

public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : notnull
{
    
}