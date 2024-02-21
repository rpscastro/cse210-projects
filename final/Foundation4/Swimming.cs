using System;

public class Swimming : Activity
{

    protected int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
        _activityName = "Swimming";
      
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance()/_length) * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

}