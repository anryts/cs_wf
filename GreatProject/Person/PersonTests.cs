using System;
using System.Windows.Forms;
using Xunit;

namespace GreatProject
{

	public class PersonTests
	{
		private readonly Person _sut1;
		private readonly Person _sut2;

		public PersonTests()
		{
			_sut1 = new Person("Тестер");
			_sut2 = new Person("");
		}

		[Fact]
		public void Name_Tester_ReturnTester()
		{
			//Arrange
			string expected = "Тестер";

			//Act
			string actual = _sut1.NameOfPerson;

			//Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void CreatePerson_EmptyName_ThrowArgumentNullException()
		{
			//Arrange

			//Assert
			Assert.Throws<ZeroLenghtException>(() => _sut2.NameOfPerson = "");
		}
	}
}
