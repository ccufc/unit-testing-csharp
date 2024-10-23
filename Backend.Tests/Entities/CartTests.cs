using Backend.Api.Entities;

namespace Backend.Tests.Entities;

public class CartTests
{
    [Fact]
    public void SetTotal_ShouldThrowException_WhenValueIsNegative()
    {
        var cart = new Cart();
        Assert.Throws<Exception>(() => cart.Total = -1m);
    }

    [Fact]
    public void SetTotal_ShouldSetTotal_WhenValueIsPositive()
    {
        var cart = new Cart();

        decimal expectedTotal = 10.99m;

        cart.Total = expectedTotal;

        Assert.Equal(expectedTotal, cart.Total);
    }

    [Fact]
    public void Add_ShouldAddItemToCart_AndUpdateTotal()
    {
        var cart = new Cart();

        var product1 = new Product
        {
            Id = 1,
            Name = "Product 1",
            Price = 5.65m
        };

        var product2 = new Product
        {
            Id = 2,
            Name = "Product 2",
            Price = 10.35m
        };

        cart.Add(product1);
        cart.Add(product2);

        Assert.Equal(2, cart.Products.Count);
        Assert.Equal(16m, cart.Total);
    }
}
