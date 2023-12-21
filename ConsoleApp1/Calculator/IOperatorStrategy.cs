namespace TerminalCalculator {

    public interface IOperatorStrategy {
        float Calculate(float firstNumber, float secondNumber);
    }

    public class AdditionStrategy : IOperatorStrategy {
        public float Calculate(float firstNumber, float secondNumber) {
            return firstNumber + secondNumber;
        }
    }

    public class SubtractionStrategy : IOperatorStrategy {
        public float Calculate(float firstNumber, float secondNumber) {
            return firstNumber - secondNumber;
        }
    }

    public class MultiplicationStrategy : IOperatorStrategy {
        public float Calculate(float firstNumber, float secondNumber) {
            return firstNumber * secondNumber;
        }
    }

    public class DivisionStrategy : IOperatorStrategy {
        public float Calculate(float firstNumber, float secondNumber) {
            return firstNumber / secondNumber;
        }
    }
}


