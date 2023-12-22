namespace TerminalCalculator {
    public class MultiplicationStrategy : IOperatorStrategy {
        public float Calculate(float firstNumber, float secondNumber) {
            return firstNumber * secondNumber;
        }
    }
}