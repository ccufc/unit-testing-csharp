namespace Backend.Api.Entities;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    private decimal _price;

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new Exception("Invalid value");

            _price = value;
        }
    }
}
