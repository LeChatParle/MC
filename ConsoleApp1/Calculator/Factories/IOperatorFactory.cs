using Calculator.Strategies;

namespace Calculator.Factories {
    interface IOperatorFactory {
        IOperatorStrategy DetermineCalculationType(string operationType);
    }
}