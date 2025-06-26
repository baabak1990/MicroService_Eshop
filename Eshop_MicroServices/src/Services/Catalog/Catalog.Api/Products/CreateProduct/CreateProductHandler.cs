using BuildingBlocks.CQRS;
using Catalog.Api.Models;

namespace Catalog.Api.Products.CreateProduct
{
    public record CreateProductCommand(
        string Name,
        List<string> Category,
        string Description,
        string ImageFile,
        decimal Price) : ICommand<CreateProductResponse>;

    public record CreateProductResponse(Guid Id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResponse> 
    {
        public async Task<CreateProductResponse> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Name = command.Name,
                Price = command.Price,
            };

            return new  CreateProductResponse( Guid.NewGuid());
          
        }
    }
}
