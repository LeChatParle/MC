using TerminalCalculator.Strategies;

namespace TerminalCalculator.Factories {
    interface IOperatorFactory {
        IOperatorStrategy DetermineCalculationType(string operationType);
    }
}