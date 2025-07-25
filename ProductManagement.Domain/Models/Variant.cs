namespace ProductManagement.Domain.Models;

public class Variant : IEquatable<Variant>
{
    public string Size { get; set; }
    public string Color { get; set; }

    public bool Equals(Variant? other)
    {
        return other is not null &&
               Size == other.Size &&
               Color == other.Color;
    }

    public override bool Equals(object? obj) => Equals(obj as Variant);
    public override int GetHashCode() => HashCode.Combine(Size, Color);
}
