using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // creating constructors 

        Fraction fractions1 = new Fraction();
        Console.WriteLine(fractions1.GetFractionString());
        Console.WriteLine(fractions1.GetFractionDecimal());

        Fraction fractions2 = new Fraction(6);
        Console.WriteLine(fractions2.GetFractionString());
        Console.WriteLine(fractions2.GetFractionDecimal());

        Fraction fractions3 = new Fraction(6,7);
        Console.WriteLine(fractions3.GetFractionString());
        Console.WriteLine(fractions3.GetFractionDecimal());

        Fraction fraction4 = new Fraction(7,6);
        Console.WriteLine(fractions3.GetFractionString());
        Console.WriteLine(fractions3.GetFractionDecimal());


        

    



    }
}