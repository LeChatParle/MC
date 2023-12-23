using Calculator.Factories;
using Calculator.Strategies;

namespace Calculator {
    public class OperatorFactory : IOperatorFactory {
        public IOperatorStrategy DetermineCalculationType(string operationType) {
            switch (operationType) {
                case "addition":
                    return new AdditionStrategy();
                case "subtraction":
                    return new SubtractionStrategy();
                case "multiplication":
                    return new MultiplicationStrategy();
                case "division":
                    return new DivisionStrategy();
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }
}