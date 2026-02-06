using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // -------------------------------
    // Constructor
    // -------------------------------
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
            )
    {
    }

    // -------------------------------
    // Required Override
    // -------------------------------
    protected override void RunActivity()
    {
        int elapsedTime = 0;

        while (elapsedTime < GetDuration())
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountdown(4);
            elapsedTime += 4;

            if (elapsedTime >= GetDuration())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountdown(6);
            elapsedTime += 6;
        }
    }
}
