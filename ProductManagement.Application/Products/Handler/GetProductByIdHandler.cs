using MediatR;
using ProductManagement.Application.Products.Queries;
using ProductManagement.Domain.Contracts;
using ProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Products.Handler;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly IProductRepository _repo;

    public GetProductByIdHandler(IProductRepository repo) => _repo = repo;

    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repo.GetByIdAsync(request.Id);
    }
}
