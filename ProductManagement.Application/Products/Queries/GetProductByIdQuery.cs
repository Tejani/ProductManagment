using MediatR;
using ProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Products.Queries;

public record GetProductByIdQuery(Guid Id) : IRequest<Product>;