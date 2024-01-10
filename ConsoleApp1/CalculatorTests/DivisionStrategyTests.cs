using Calculator.Strategies;
using Shouldly;

namespace Calculator.CalculatorTests {
    public class DivisionStrategyTests {

        public DivisionStrategy _sut; //System Under Test - the thing being tested
        public DivisionStrategyTests() { //we do this because the framework will call this for us
            _sut = new DivisionStrategy(); //created object to test
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
        public void Calculate_GivenTwoNumbers_ThenDivideThem(float first, float second) {

            //Arrange
            var expected = first / second;

            //Act -  where you run your method
            var actual = _sut.Calculate(first, second);

            //Assert
            actual.ShouldBe(expected);
        }
    }
}