using Calculator.Strategies;
using Shouldly;

namespace Calculator.CalculatorTests {
    public class DivisionStrategyTests {

        public DivisionStrategy _sut; //System Under Test - the thing being tested
        public DivisionStrategyTests() {
            _sut = new DivisionStrategy(); //created object to test
        }

        [Theory]
        [InlineData(5, 3)]
        [InlineData(9, 9)]
        [InlineData(4, 88)]
        [InlineData(1, 3)]
        [InlineData(-4, 9)]
        [InlineData(123, 88)]
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