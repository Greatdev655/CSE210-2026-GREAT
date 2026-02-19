using System;

namespace ExerciseTracking;

public abstract class Activity
{
    private DateTime _date;
    private double _minutes;

    public Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public double GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} - {this.GetType().Name}, {GetMinutes():F1} min - {GetDistance():F1} miles, {GetSpeed():F1} mph, {GetPace():F1} min per mile";
    }
}