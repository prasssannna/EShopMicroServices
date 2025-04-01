using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)   : ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);

public class CreateProductCommandValidator : ICommandHandler<CreateProductCommand, CreateProductResult>
{

    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //Create Prodcut entity from command object. Refer line 5       
        var product = new Product()
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
             ImageFile = command.ImageFile,
             Price = command.Price 
        };

        //TODO
        //save to database

        //Return the result refer line 6
        return new CreateProductResult(Guid.NewGuid());
    }
}

