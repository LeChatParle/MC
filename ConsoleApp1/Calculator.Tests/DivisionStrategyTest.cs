using Shouldly;
using TerminalCalculator;

namespace Calculator.Tests
{
    public class DivisionStrategyTest
    {
        public DivisionStrategy _sut;

        public DivisionStrategyTest()
        {
            _sut = new DivisionStrategy();
        }

        [Theory]
        [InlineData(5, 3)]
        public void Calculate_GivenTwoNumbers_ThenDivideThem(float first, float second)
        {
            // Arrange
            var expected = first / second;

            // Act
            var actual = _sut.Calculate(first, second);

            // Assert
            actual.ShouldBe(expected);
        }
    }
}
