using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Alice", "fraction");
        Assignment assignment2 = new Assignment("Majesty", "laws of marketing");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment2.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Great", "Polynomials", "Section 5.2", "4-12");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeWorkList());
        

    }
}