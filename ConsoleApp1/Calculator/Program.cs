using System.Linq.Expressions;

//Variables
int i = 0;
int firstNumber;
int secondNumber;

//Logic
System.Console.WriteLine("Welcome to Calculon 9000");
RequestValuesFromUser();






// Functions
void ValidateNumber(string enteredValue) {

    if (int.TryParse(enteredValue, out firstNumber) && i != 1) {
        System.Console.WriteLine("Successfully recorded first number");
        i++;
    } else if (int.TryParse(enteredValue, out secondNumber) && i != 2) {
        System.Console.WriteLine("Successfully recorded second number");
        i++;
    } else {
        System.Console.WriteLine("Invalid response. Try again:");
        ValidateNumber(Console.ReadLine());
    }
}

void RequestValuesFromUser() {
    System.Console.WriteLine($"Enter a number now:"); 
    ValidateNumber(Console.ReadLine());
    System.Console.WriteLine($"Enter another number now:"); 
    ValidateNumber(Console.ReadLine());
}