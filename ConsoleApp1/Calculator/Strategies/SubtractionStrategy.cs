namespace TerminalCalculator.Strategies {
    public class SubtractionStrategy : IOperatorStrategy {
        public float Calculate(float firstNumber, float secondNumber) {
            return firstNumber - secondNumber;
        }
    }
}