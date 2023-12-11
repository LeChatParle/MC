using System;
using System.Transactions;

Console.WriteLine("Hello, and welcome to your to-do list!");
Console.WriteLine("What would you like to do?");

Console.WriteLine("[S]ee your to-dos");
Console.WriteLine("[A]dd a to-do");
Console.WriteLine("[R]emove a to-do");
Console.WriteLine("[E]xit");

var userInput = Console.ReadLine();

/* switch (userInput.ToLower())
{
    case "s":
        System.Console.WriteLine("Here are your to-dos:");
        break;
    case "a":
        System.Console.WriteLine("Enter a to-do:");
        break;
    case "r":
        System.Console.WriteLine("Enter the number of the to-do you'd like to remove:");
        break;
    case "e":
        System.Console.WriteLine("Now exiting");
        break;
    default:
    break;
} */

Console.WriteLine(userInput);