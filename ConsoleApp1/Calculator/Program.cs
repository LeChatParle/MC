using System.Linq.Expressions;

namespace TerminalCalculator
{
    class Calculator
    {
        static int i = 0;
        static float firstNumber = 0;
        static float secondNumber = 0;
        static string operationType;

        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Welcome to Calculon 9000");
            System.Console.WriteLine($"Enter a number now:"); 

            ValidateNumber(Console.ReadLine());

            System.Console.WriteLine($"Enter another number now:"); 
            ValidateNumber(Console.ReadLine());

            System.Console.WriteLine($"Enter operation type: Addition, Subtraction, Multiplication, or Division.");
            ValidateOperationType(Console.ReadLine());

            System.Console.WriteLine(Calculate());
        }

        static void ValidateNumber(string enteredValue) {

            if (i != 1 && float.TryParse(enteredValue, out firstNumber)) {
                System.Console.WriteLine("Successfully recorded first number");
                i++;
            } else if (i != 2 && float.TryParse(enteredValue, out secondNumber)) {
                System.Console.WriteLine("Successfully recorded second number");

                if (secondNumber == 0) {
                    System.Console.WriteLine("Warning: your second number is 0. You may not choose division as an operation type");
                }

                i++;
            } else {
                System.Console.WriteLine("Invalid number. Try again:");
                ValidateNumber(Console.ReadLine());
            }   
        }

        //Refactor
        static void ValidateOperationType(string enteredValue) {

            string normalisedData = enteredValue.ToLower();

            if (normalisedData == "addition" || normalisedData == "a" || normalisedData == "+") {
                operationType = "addition";
            } else if (normalisedData == "subtraction" || normalisedData == "s" || normalisedData == "-") {
                operationType = "subtraction";
            } else if ((normalisedData == "division" || normalisedData == "d" || normalisedData == "/" || normalisedData == "\\" || normalisedData == "÷") && secondNumber != 0) {
                operationType = "division";
            } else if (normalisedData == "multiplication" || normalisedData == "m" || normalisedData == "*") {
                operationType = "multiplication";
            } else {
                System.Console.WriteLine("invalid operation type. Please re-enter:");
                ValidateOperationType(Console.ReadLine());
            }
        }

        static float Calculate() {
            
            if (operationType == "addition") {
                return firstNumber + secondNumber;
            } else if (operationType == "subtraction") {
                return secondNumber - firstNumber;
            } else if (operationType == "division" ) {
                return firstNumber / secondNumber;
            } else {
                return firstNumber * secondNumber;
            }
        }
    }
}