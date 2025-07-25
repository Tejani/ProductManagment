using ProductManagement.Domain.Models;

namespace ProductManagement.Domain.Contracts;

public interface IProductRepository
{
    Task<Product?> GetByIdAsync(Guid id);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task<List<Product>> GetAllAsync();
}
