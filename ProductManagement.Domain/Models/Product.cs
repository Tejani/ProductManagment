using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Models
{
    public class Product
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public decimal Price { get; private set; }
        public bool IsActive { get; private set; }
        public List<Variant> Variants { get; private set; } = new();

        public Product(string name, string description, string category, decimal price)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
            IsActive = false;
        }

        public void AddVariant(Variant variant)
        {
            if (Variants.Any(v => v.Equals(variant)))
                throw new InvalidOperationException("Duplicate variant is not allowed.");

            Variants.Add(variant);
        }

        public void Activate()
        {
            if (Price <= 0)
                throw new InvalidOperationException("Product cannot be activated with non-positive price.");

            IsActive = true;
        }

        public void Deactivate() => IsActive = false;

        public void UpdateDetails(string name, string description, string category, decimal price)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
        }
    }
}
