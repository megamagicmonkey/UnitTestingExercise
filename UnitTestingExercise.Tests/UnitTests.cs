using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2,2,2,6)]
        [InlineData(5, 9, 0, 14)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(10, 20, 30, 60)]
        [InlineData(0, 0, 2, 2)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();

            //Act
            var actual = unitTestMethod.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0, 0 , 0)]
        [InlineData(10, 5, 5)]
        [InlineData(10, 10, 0)]
        [InlineData(21, 20, 1)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();

            //Act
            var actual = unitTestMethod.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(1, 20, 20)]
        [InlineData(20, 1, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();

            //Act
            var actual = unitTestMethod.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(21, 1, 21)]
        [InlineData(99, 33, 3)]
        [InlineData(0, 1, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();

            //Act
            var actual = unitTestMethod.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MrSimple()
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();

            //Act
            var actual = unitTestMethod.MrSimple();

            //Assert
            Assert.Equal("I think it's simple.", actual);

        }

        [Fact]
        public void MrThought()
        {
            //Arrange
            var unitTestMethod = new UnitTestMethods();

            //Act
            var actual = unitTestMethod.MrThought();

            //Assert
            Assert.Equal("It's a simple thought.", actual);
        }
    }
}
