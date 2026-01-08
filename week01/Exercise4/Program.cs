using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");


        // create initial constants.  

        int number = -1;
        List<int>numberList = new List<int>();

        // create a loop to ask user for a list of number till the enter 0

        while(number != 0)
        {
            Console.WriteLine("Please Enter A Number(0 to quit):");
            number = int.Parse(Console.ReadLine());
            if(number != 0)
            {
                numberList.Add(number);
            }
        }

        //  compute the sum 

        int sum = 0;
        foreach(int numbers in numberList)
        {
            sum +=numbers;
        } 

        Console.WriteLine($"the sum is: {sum}");

        // calculate the average of the numbers 
        float average = 0;
        foreach(int numbers in numberList)
        {
            average = ((float)sum) / numberList.Count;
        }

        Console.WriteLine($"the average of the numbers is {average}");






    }
}