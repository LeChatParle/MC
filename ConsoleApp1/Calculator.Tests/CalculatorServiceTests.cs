using Moq;
using Shouldly;
using TerminalCalculator;

namespace Calculator.Tests
{
    public class CalculatorServiceTests
    {
        private Mock<IOperatorFactory> _mockFactory;

        public CalculatorServiceTests()
        {
            _mockFactory = new Mock<IOperatorFactory>();
        }

        [Fact]
        // This is a bad test, we are testing two concrete objects.
        // Should only be testing 'CalculatorService' and not 'AdditionStrategy'.
        public void Execute_GivenTwoNumbersAndAnOperator_ThenReturnTheCalculatedValue_BAD()
        {
            // Arrange
            var fakeNumber1 = 1;
            var fakeNumber2 = 2;
            var fakeOperator = "+";

            var expectedValue = 3;

            _mockFactory
                .Setup(x => x.DetermineCalculationType(It.IsAny<string>()))
                .Returns(new AdditionStrategy());

            // Act
            var sut = new CalculatorService(_mockFactory.Object);
            var actual = sut.Execute(fakeNumber1, fakeOperator, fakeNumber2);

            // Assert
            actual.ShouldBe(expectedValue);
        }

        [Fact]
        public void Execute_GivenTwoNumbersAndAnOperator_ThenReturnTheCalculatedValue2_GOOD()
        {
            // Arrange
            var fakeNumber1 = 1;
            var fakeNumber2 = 2;
            var fakeOperator = "test";

            var expectedValue = 10;

            var mockStrategy = new Mock<IOperatorStrategy>();
            mockStrategy
                .Setup(x => x.Calculate(It.IsAny<float>(), It.IsAny<float>()))
                .Returns(expectedValue);

            _mockFactory
                .Setup(x => x.DetermineCalculationType(It.IsAny<string>()))
                .Returns(mockStrategy.Object);

            // Act
            var sut = new CalculatorService(_mockFactory.Object);
            var actual = sut.Execute(fakeNumber1, fakeOperator, fakeNumber2);

            // Assert
            _mockFactory.Verify(x => x.DetermineCalculationType(It.IsAny<string>()), Times.Once);
            mockStrategy.Verify(x => x.Calculate(It.IsAny<float>(), It.IsAny<float>()), Times.Once);
        }
    }
}
