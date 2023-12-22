namespace TerminalCalculator {
    public class AdditionStrategy : IOperatorStrategy {
        public float Calculate(float firstNumber, float secondNumber) {
            return firstNumber + secondNumber;
        }
    }
}