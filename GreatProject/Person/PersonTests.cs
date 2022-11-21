using System;
using System.Windows.Forms;
using Xunit;

namespace GreatProject;

public class PersonTests
{
	[Fact]
	public void Name_Tester_ReturnTester()
    {
		//Arrange
		var sut = new Person("Тестер");
		string expected = "Тестер";

		//Act
		string actual = sut.NameOfPerson;

		//Assert
		Assert.Equal(expected, actual);
	}

	[Fact]
	public void CreatePerson_EmptyName_ThrowArgumentNullException()
    {
		//Arrange
		var sut = new Person("");

		//Assert
		Assert.Throw<ZeroLenghtException>(() => sut._nameOfPerson = "");
	}
}
