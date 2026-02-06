using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // -------------------------------
    // Fields
    // -------------------------------
    private List<string> _prompts;
    private List<string> _items;
    private Random _random;

    // -------------------------------
    // Constructor
    // -------------------------------
    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
          )
    {
        _random = new Random();

        _items = new List<string>();

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // -------------------------------
    // Required Override
    // -------------------------------
    protected override void RunActivity()
    {
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("You may begin listing items in:");
        ShowCountdown(5);

        _items.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                _items.Add(item);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_items.Count} items.");
    }

    // -------------------------------
    // Private Helper Method
    // -------------------------------
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
