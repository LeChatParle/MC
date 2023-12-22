namespace TerminalCalculator.Strategies {
    public class DivisionStrategy : IOperatorStrategy {
        public float Calculate(float firstNumber, float secondNumber) {
            return firstNumber / secondNumber;
        }
    }
}