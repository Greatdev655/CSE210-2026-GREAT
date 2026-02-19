using System;

namespace ExerciseTracking;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double minutes, int laps):base(date, minutes)
    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public override double GetDistance()
    {
        // using miles cause thats what ive been using . i want to remain consistent. 
        return GetLaps() * 50/1000 * 0.62; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes())*60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    } 

}



