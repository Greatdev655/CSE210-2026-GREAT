using System;


public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
            return 0;

        _isComplete = true;
        return _points;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
        => _isComplete ? "[X]" : "[ ]";

    public override string GetDetailsString()
        => $"{GetStatus()} {Name} ({Description})";

    public override string Serialize()
        => $"Simple|{Name}|{Description}|{_points}|{_isComplete}";
}
