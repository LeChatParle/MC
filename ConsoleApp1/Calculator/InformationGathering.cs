namespace TerminalCalculator {
    public class Gathering {

       public float GetNumber(bool isFirstNumber) {
            float firstNumber;
            float secondNumber ;

            while (true) {
                var value = Console.ReadLine();

                if (isFirstNumber && float.TryParse(value, out firstNumber)) {
                    System.Console.WriteLine("Successfully recorded first number"); 
                    return firstNumber;
                } else if (!isFirstNumber && float.TryParse(value, out secondNumber)) {
                    System.Console.WriteLine("Successfully recorded second number"); 
                    if (!isFirstNumber && secondNumber == 0) {
                        System.Console.WriteLine("Warning: your second number is 0. You may not choose division as an operation type");
                    }
                    return secondNumber;
                } else {
                    System.Console.WriteLine("Invalid number. Try again:");
                }
            }
        }

        public string GetOperationSymbol(string operationType) {
            return operationType switch {
                "addition" => "+",
                "subtraction" => "-",
                "multiplication" => "*",
                _ => "/"
            };
        } 
    }
    
}