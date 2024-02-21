using System;

public class Cycling : Activity
{

    protected double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
        _activityName = "Cycling";
      
    }

    public override double GetDistance()
    {
        return _speed / 60 * _length;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }


}