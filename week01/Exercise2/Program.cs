using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");


          // grade program 

        Console.Write("Enter your grade:");
        string grade = Console.ReadLine();
        int score = int.Parse(grade);

        string letter = "";

        if(score >= 90)
        {
            letter = "A";
        }
        else if(score >= 80)
        {
            letter = "B";
        }
        else if(score >= 70)
        {
            letter = "C";
        }
        else if(score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");


        if(score >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("nice try but better luck next time");
        }
    }
}
