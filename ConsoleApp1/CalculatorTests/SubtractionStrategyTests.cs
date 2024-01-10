using Calculator.Strategies;
using Shouldly;

namespace Calculator.CalculatorTests
{
    public class SubtractionStrategyTests
    {
        public SubtractionStrategy _sut;

        public SubtractionStrategyTests() {
            _sut = new SubtractionStrategy();
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

        public void Calculate_GivenTwoNumbers_ThenSubtractThem(float first, float second)
        {
            //Arrange
            var expected = first - second;

            //Act
            var actual = _sut.Calculate(first, second);

            //Assert
            actual.ShouldBe(expected);
        }

    }
}