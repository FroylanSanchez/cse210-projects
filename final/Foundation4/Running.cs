class Running : Activity
{
    protected double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        if (_distance != 0)
        {
            return _distance / _minutes * 60;
        }
        else
        {
            return 0.0;
        }
    }

    public override double GetPace()
    {
        if (_distance != 0)
        {
            return _minutes / _distance;
        }
        else
        {
            return 0.0;
        }
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} min) - Distance {_distance} miles, Speed {(GetSpeed()).ToString("0.0")} mph, Pace: {(GetPace() * 60).ToString("0.0")} min per mile";
    }
}