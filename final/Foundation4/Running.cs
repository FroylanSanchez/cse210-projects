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
        return _distance != 0 ? _distance / _minutes * 60 : 0.0;
    }

    public override double GetPace()
    {
        return _distance != 0 ? _minutes / _distance : 0.0;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} min) - Distance {_distance} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
