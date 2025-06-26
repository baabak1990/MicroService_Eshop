using MediatR;
namespace BuildingBlocks.CQRS;


public interface ICommand: ICommand<uint>
{

}
public interface ICommand<out TResponse>:IRequest<TResponse>
{
    
}