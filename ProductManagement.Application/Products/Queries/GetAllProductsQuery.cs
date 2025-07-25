using MediatR;
using ProductManagement.Domain.Models;

namespace ProductManagement.Application.Products.Queries;

public record GetAllProductsQuery() : IRequest<List<Product>>;
