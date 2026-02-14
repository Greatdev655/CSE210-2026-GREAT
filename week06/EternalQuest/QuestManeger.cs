using System;

using System;
using System.Collections.Generic;

public class QuestManager
{
    private List<Goal> _goals = new();
    private int _score;

    public int Score => _score;

    public void AddGoal(Goal goal)
        => _goals.Add(goal);

    public void RecordGoal(int index)
    {
        if (index < 0 || index >= _goals.Count)
            return;

        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public List<Goal> GetGoals() => _goals;

    public void SetScore(int score) => _score = score;
}
