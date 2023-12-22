using TerminalCalculator;

namespace Calculator
{
    public class CalculatorService
    {
        private readonly IOperatorFactory _operatorFactory;

        public CalculatorService(IOperatorFactory operatorFactory)
        {
            _operatorFactory = operatorFactory;
        }

        public float Execute(float firstNumber, string operationType, float secondNumber)
        {
            var calculate = _operatorFactory.DetermineCalculationType(operationType);

            var result = calculate.Calculate(firstNumber, secondNumber);

            if (result == 69.0f)
            {
                return 420.0f;
            }
            
            return result;
        }
    }
}
