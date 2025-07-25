using MediatR;
using ProductManagement.Application.Products.Commands;
using ProductManagement.Domain.Contracts;
using ProductManagement.Domain.Models;

namespace ProductManagement.Application.Products.Handler;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _repo;

    public CreateProductHandler(IProductRepository repo) => _repo = repo;

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product(request.Name, request.Description, request.Category, request.Price);

        foreach (var variant in request.Variants)
        {
            product.AddVariant(variant);
        }
        
        await _repo.AddAsync(product);
        return product.Id;
    }
}
