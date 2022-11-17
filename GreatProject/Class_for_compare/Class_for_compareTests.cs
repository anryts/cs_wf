using System;
using System.Windows.Forms;
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
        [Fact]
        public void print_material_info()
        {
            // Arrange
            string str = "Name:Metal Capacity:100  Weight:15 ";
            // Act
            var result =_sut1.Print_Info();
            // Assert
            Assert.Equal(str, result);
        }
        //[Fact]
        //public void Compare_food_1biggerthan2_return1()
        //{
        //    DateTime exp1 = new DateTime(2015, 7, 20, 18, 30, 25);
        //    DateTime exp2 = new DateTime(2010, 1, 1, 0, 0, 0);
        //    //Arrange
        //    var result = false;
        //    var item1 = new Food("apple", exp1);            
        //    var item2 = new Food("potato", exp2);
        //    //Act
        //    if (item1.price_of_item() < item2.price_of_item())
        //    {
        //        result = true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    //Assert
        //    Assert.True(result);
        //}
    }
}