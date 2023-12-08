using system;



class Program
{
    static void Main()
    {
        System.Console.WriteLine("Welcome to Calculon 3000! The world's premiere calculating bot since 2023");
        System.Console.WriteLine("Please enter the first number");

        var firstNumber = Console.ReadLine();

        System.Console.WriteLine("Please enter the second number");
        var secondNumber = Console.ReadLine();

        System.Console.WriteLine("Please enter the type of calculation you want to do (addition, subtraction, multiplication, or division)");
        var calculationType = Console.ReadLine().ToLower();

        if (calculationType == "addition") {}
        else if (calculationType == "subtraction") {}
        else if (calculationType == "multiplication") {}
        else if (calculationType == "division") {}
        else {}
    }
}