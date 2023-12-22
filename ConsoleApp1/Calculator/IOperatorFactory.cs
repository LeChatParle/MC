namespace TerminalCalculator {
    interface IOperatorFactory {
        IOperatorStrategy DetermineCalculationType(string operationType);
    }
}