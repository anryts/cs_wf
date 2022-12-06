using System;
using Xunit;

namespace GreatProject;

public class FoodTests
{
    private readonly Food _sut;

    public FoodTests()
    {
        _sut = new Food("Bread", new DateTime(2023, 12, 31));
    }

    [Fact]
    public void GetData_ReturnsCorrectData()
    {
        var expected = "Price:39000\nName:Bread\nExpiration Date:12.31.2023";


        var result = _sut.Print_Info();


        Assert.Equal(expected, result);


    }


    [Fact]
    public void GetPrice_ReturnsCorrectPrice()
    {
        var expected = 39000;


        var result = _sut.price_of_item();


        Assert.Equal(expected, result);


    }


    [Fact]
    public void CheckIfFoodIsFresh_ReturnsTrue()
    {
        var result = _sut.Fresh_or_not(_sut.ExpirationDate);

        Assert.True(result);
    }

}