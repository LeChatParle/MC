using Calculator.Strategies;
using Shouldly;

namespace Calculator.CalculatorTests
{
    public class MultiplicationStategyTests
    {
        public MultiplicationStrategy _sut;

        public MultiplicationStategyTests() { 
            _sut = new MultiplicationStrategy();
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(-1, 3)]
        [InlineData(1, -3)]
        [InlineData(-1, -3)]
        [InlineData(1.5, 3.5)]
        [InlineData(-1.5, 3.5)]
        [InlineData(1.5, -3.5)]
        [InlineData(-1.5, -3.5)]
        [InlineData(3, 1)]
        [InlineData(-3, 1)]
        [InlineData(3, -1)]
        [InlineData(-3, -1)]
        [InlineData(3.5, 1.5)]
        [InlineData(-3.5, 1.5)]
        [InlineData(3.5, -1.5)]
        [InlineData(-3.5, -1.5)]

        public void Calculate_GivenTwoNumbers_ThenMultiplyThem(float first, float second)
        {
            //arrange
            var expected = first * second;

            //Act
            var actual = _sut.Calculate(first, second);

            //Assert
            actual.ShouldBe(expected);
        }
    }
}