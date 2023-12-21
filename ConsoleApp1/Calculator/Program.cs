namespace TerminalCalculator {
    class Calculator
    {
        static float firstNumber = 0;
        static float secondNumber = 0;
        static string operationType = "";
        static string operationSymbol = "";
        static float calculatedValue = 0;

        static void Main(string[] args)
        {

            System.Console.WriteLine("Welcome to Calculon 9000");
            
            System.Console.WriteLine($"Enter a number now:"); 
            Gathering Information = new Gathering();

            firstNumber = Information.GetNumber(true);

            System.Console.WriteLine($"Enter another number now:"); 
            secondNumber = Information.GetNumber(false);

            System.Console.WriteLine($"Enter operation type: Addition, Subtraction, Multiplication, or Division.");
            operationType = Validator.ValidateOperationType(secondNumber);

            DetermineHowToCalculate MakeDetermination = new DetermineHowToCalculate();
            IOperatorStrategy Calculate = MakeDetermination.DetermineCalculationType(operationType);

            operationSymbol = Information.GetOperationSymbol(operationType);
     
            calculatedValue = Calculate.Calculate(firstNumber, secondNumber);
            
            System.Console.WriteLine($"{firstNumber} {operationSymbol} {secondNumber} = {calculatedValue}");    
            
        }
    }
}