namespace TerminalCalculator {
    public class DivisionStrategy : IOperatorStrategy {
        public float Calculate(float firstNumber, float secondNumber) {
            return firstNumber / secondNumber;
        }
    }
}