namespace TerminalCalculator {
    public interface IOperatorFactory {
        IOperatorStrategy DetermineCalculationType(string operationType);
    }
}