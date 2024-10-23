using Backend.Api.Entities;

namespace Backend.Tests.Entities;

public class ProductTests
{
    [Fact]
    public void SetPrice_ShouldThrowException_WhenValueIsNegative()
    {
        var product = new Product();
        Assert.Throws<Exception>(() => product.Price = -1m);
    }

    [Fact]
    public void SetPrice_ShouldSetValue_WhenValueIsPositive()
    {
        var product = new Product();

        decimal expectedPrice = 10.99m;

        product.Price = expectedPrice;

        Assert.Equal(expectedPrice, product.Price);
    }
}
