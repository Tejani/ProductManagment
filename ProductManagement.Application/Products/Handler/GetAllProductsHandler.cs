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

public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IProductRepository _repo;

    public GetAllProductsHandler(IProductRepository repo) => _repo = repo;

    public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await _repo.GetAllAsync();
    }
}
