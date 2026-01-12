using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int square = SquareNumber(userNumber);

        DisplayResult(userName , square); 
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome To The Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter Your Name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(string name , int numberSquared)
    {
        Console.WriteLine($"{name},  the square of your favorite number is {numberSquared}");
    }

    



    
}