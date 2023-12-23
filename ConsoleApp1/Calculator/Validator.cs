namespace Calculator {
    public class Validator {
        public static string ValidateOperationType(float secondNumber) {

            while (true) {

                string normalisedData = Console.ReadLine()!.ToLower();

                if (normalisedData == "addition" || normalisedData == "a" || normalisedData == "+" || normalisedData == "add") {
                    return "addition"; 
                } else if (normalisedData == "subtraction" || normalisedData == "s" || normalisedData == "-" || normalisedData == "subtract") {
                    return "subtraction";
                } else if ((normalisedData == "division" || normalisedData == "d" || normalisedData == "/" || normalisedData == "\\" || normalisedData == "÷" || normalisedData == "divide") && secondNumber != 0) {
                    return "division";
                } else if (normalisedData == "multiplication" || normalisedData == "m" || normalisedData == "*" || normalisedData == "multiply") {
                    return "multiplication";
                } else {
                    System.Console.WriteLine("invalid operation type. Please re-enter:");
                }   
            }
        }
    }
}