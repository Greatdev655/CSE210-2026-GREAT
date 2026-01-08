using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");


        // number guessing game 


        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;


        while(guess != magicNumber)
        {

            Console.Write("what is your guess?:");
            guess = int.Parse(Console.ReadLine()); 

            if(guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if(guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("you guessed it right!");
            }

        }


        
    }
}