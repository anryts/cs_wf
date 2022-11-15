using System;
using Xunit;

namespace GreatProject;

public class MaterialsTests
{
    private readonly Materials _sut;

    public MaterialsTests()
    {
        _sut = new Materials(name: "Metal", capacity: 100, weight: 15);
    }

    [Fact]
    public void CompareTo_TwoMaterials_ShouldReturnBool()
    {
        //Arrange
        var material1 = new Materials(name: "Wood", capacity: 10, weight: 10);

        //Act
        var result = _sut.CompareTo(material1);
        //Assert
        Assert.True(result);
    }

    [Fact]
    public void Print_Info_Material_ShouldReturnString()
    {
        //Arrange
        var expected = "Name:Metal Capacity:100  Weight:15 ";

        //Act
        var result = _sut.Print_Info();
        //Assert
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(1000, false)]
    [InlineData(1.50, false)]
    [InlineData(-10, false)]
    [InlineData(0, false)]
    [InlineData(2250, true)]
    public void PriceOfMaterials_Nothing_ShouldReturnPrice(double expected, bool isTrue)
    {
        //Arrange
        var material = new Materials(name: "Metal", capacity: 100, weight: 15);
        //Act
        var result = material.price_of_Materials();
        //Assert
        Assert.Equal(isTrue, Math.Abs(result - expected) < 0.0001);
    }

    [Fact]
    public void MaterialsWrongCapacity_InvalidCapacity_ShouldFailed()
    {
        int capacity = -1;
        Assert.Throws<CapacityException>(() => _sut.Capacity = capacity);
    }
}