using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // --------------------------------------------------
        // Exceeding Requirements:
        // This program supports a small library of scriptures.
        // One scripture is randomly selected at runtime for
        // memorization instead of using a single hard-coded one.
        // --------------------------------------------------

        // 1. Create a library of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>();

        scriptureLibrary.Add(
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            )
        );

        scriptureLibrary.Add(
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths"
            )
        );

        scriptureLibrary.Add(
            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want"
            )
        );

        // 2. Select a random scripture from the library
        Random random = new Random();
        Scripture scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        // 3. Main program loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }
        }
    }
}
