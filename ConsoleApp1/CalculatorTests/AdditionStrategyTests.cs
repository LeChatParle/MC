using Calculator.Strategies;
using Shouldly;

namespace Calculator.CalculatorTests {

    public class AdditionStrategyTests {

        public AdditionStrategy _sut;

        public AdditionStrategyTests()  {
            _sut = new AdditionStrategy();
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

        public void Calculate_GivenTwoNumbers_ThenAddThem(float first, float second)
        {
            //Arrange
            var expected = first + second;

            //Act -  where you run your method
            var actual = _sut.Calculate(first, second);

            //Assert
            actual.ShouldBe(expected);
        }

    }

}
