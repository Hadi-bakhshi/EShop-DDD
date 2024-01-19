namespace Domain.Products;

// stock keeping unit 
public record Sku
{
    private const int DefaultLength = 15;
    // private constructor 
    private Sku(string value) => Value = value;

    // we want it to be immutable
    public string Value { get; init; }

    // Factory method 
    public static Sku? Create(string value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        if (value.Length != DefaultLength) return null;
        return new Sku(value);
    }
}