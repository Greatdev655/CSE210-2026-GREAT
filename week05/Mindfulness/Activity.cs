using System;
using System.Threading;

public abstract class Activity
{
    // -------------------------------
    // Fields (Encapsulation)
    // -------------------------------
    private string _name;
    private string _description;
    private int _duration;

    // -------------------------------
    // Constructor
    // -------------------------------
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // -------------------------------
    // Public Methods
    // -------------------------------

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        SetDuration();

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        RunActivity();

        End();
    }

    public void End()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    // -------------------------------
    // Protected Methods
    // -------------------------------

    protected int GetDuration()
    {
        return _duration;
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // -------------------------------
    // Private Methods
    // -------------------------------

    private void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    // -------------------------------
    // Abstract Method
    // -------------------------------

    protected abstract void RunActivity();
}
