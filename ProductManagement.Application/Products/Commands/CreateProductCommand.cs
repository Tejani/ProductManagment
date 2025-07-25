using MediatR;
using ProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Products.Commands;

public record CreateProductCommand(
   string Name,
   string Description,
   string Category,
   decimal Price,
   List<Variant> Variants) : IRequest<Guid>;
