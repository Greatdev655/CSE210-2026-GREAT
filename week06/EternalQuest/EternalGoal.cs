using System;



public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
        => _points;

    public override bool IsComplete()
        => false; 

    public override string GetStatus()
        => "[∞]";

    public override string GetDetailsString()
        => $"{GetStatus()} {Name} ({Description})";

    public override string Serialize()
        => $"Eternal|{Name}|{Description}|{_points}";
}
