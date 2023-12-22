using Calculator;

namespace TerminalCalculator
{
    class Calculator {
        static void Main(string[] args)
        {
            var makeDetermination = new DetermineHowToCalculate();

            System.Console.WriteLine("Welcome to Calculon 9000");
            
            System.Console.WriteLine($"Enter a number now:"); 
            var information = new Gathering();

            var firstNumber = information.GetNumber(true);

            System.Console.WriteLine($"Enter another number now:"); 
            var secondNumber = information.GetNumber(false);

            System.Console.WriteLine($"Enter operation type: Addition, Subtraction, Multiplication, or Division.");
            var operationType = Validator.ValidateOperationType(secondNumber);
            var operationSymbol = information.GetOperationSymbol(operationType);

            var calculatorService = new CalculatorService(makeDetermination);
            var calculatedValue = calculatorService.Execute(firstNumber, operationType, secondNumber);

            System.Console.WriteLine($"{firstNumber} {operationSymbol} {secondNumber} = {calculatedValue}");    
            
        }
    }
}