namespace Backend.Api.Entities;

public class Cart
{
    public int Id { get; set; }
    public List<Product> Products { get; set; } = [];
    private decimal _total;

    public decimal Total
    {
        get => _total;
        set
        {
            if (value < 0)
                throw new Exception("Invalid value");

            _total = value;
        }
    }

    public void Add(Product product)
    {
        Products.Add(product);
        Total += product.Price;
    }

    public void Remove(Product product)
    {
        Products.Remove(product);
        Total -= product.Price;
    }
}
