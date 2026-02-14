using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points,
        int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
            return 0;

        _currentCount++;

        if (_currentCount == _targetCount)
            return _points + _bonus;

        return _points;
    }

    public override bool IsComplete()
        => _currentCount >= _targetCount;

    public override string GetStatus()
        => $"[{(_currentCount >= _targetCount ? "X" : " ")}] Completed {_currentCount}/{_targetCount}";

    public override string GetDetailsString()
        => $"{GetStatus()} {Name} ({Description})";

    public override string Serialize()
        => $"Checklist|{Name}|{Description}|{_points}|{_currentCount}|{_targetCount}|{_bonus}";
}
