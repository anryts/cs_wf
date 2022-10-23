using Xunit;
using Xunit.Sdk;

namespace GreatProject;

public class MaterialsTests
{
    private readonly Materials _sut;

    public MaterialsTests()
    {
        _sut = new Materials(name:"Metal", capacity: 100, weight:15);
    }

    [Fact]
    public void CompareTo_TwoMaterials_ShouldReturnBool ()
    {
       //Arrange
         var material1 = new Materials(name:"Wood", capacity: 10, weight:10);
         
        //Act
        var result = _sut.CompareTo(material1);
        //Assert
        Assert.True(result);
    }
    
}