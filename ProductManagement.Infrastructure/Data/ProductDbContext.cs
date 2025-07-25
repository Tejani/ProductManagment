using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Infrastructure.Data;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(p =>
        {
            p.HasKey(x => x.Id);
            p.OwnsMany(x => x.Variants, v =>
            {
                v.WithOwner();
                v.Property(v => v.Size);
                v.Property(v => v.Color);
                v.HasKey("Size", "Color");
            });
        });
    }
}
