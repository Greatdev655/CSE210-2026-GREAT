using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What challenged me today?",
        "What made me smile today?",
        "If I could relive one moment today, what would it be?",
        "What am I grateful for today?",
        "What is one thing I learned today?",
        "what was the strongest emotion I felt today?"


    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
