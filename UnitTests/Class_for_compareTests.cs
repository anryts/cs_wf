using System;
using Xunit;

namespace GreatProject
{
    public class Class_for_compareTests
    {
        private readonly Materials _sut1;
        private readonly Materials _sut2;
        //private readonly Food _sut2;

        public Class_for_compareTests()
        {
            _sut1 = new Materials(name: "Metal", capacity: 100, weight: 15);
            _sut2 = new Materials(name: "Wood", capacity: 1, weight: 1);
        }

        [Fact]
        public void Compare_materials_1biggerthan2_return1 ()
        {
            //Arrange
            var material1 = new Materials(name: "Wood", capacity: 10, weight: 10);

            //Act
            var result = _sut1.CompareTo(material1);
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void Compare_materials_2biggerthan1_return1()
        {
            //Arrange
            var material1 = new Materials(name: "Metal", capacity: 10, weight: 10);

            //Act
            var result = _sut2.CompareTo(material1);
            //Assert
            Assert.False(result);
        }

        
    }
}