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
    public void PriceOfMaterials_Nothing_ShouldReturnPrice()
    {
        //Arrange
        double exprectedPrice = 2250;

        //Act

        var result = _sut.price_of_Materials();

        //Assert
        Assert.Equal(exprectedPrice, result);
    }
    [Theory]
                        [InlineData(-1)]
                        [InlineData(-5)]
                        [InlineData(-3)]
                        [InlineData(-2)]
    public void MaterialsWrongCapacity_InvalidCapacity_ShouldFailed(int capacity)
    {
        Assert.Throws<CapacityException>(() => _sut.Capacity = capacity);
    }

}