class Swimming : Activity
{
    protected int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }
    public override double GetSpeed()
    {
        if (GetDistance() != 0)
        {
            return GetDistance() / _minutes * 60;
        }
        else
        {
            return 0.0;
        }
    }
    public override double GetPace()
    {
        if (GetDistance() != 0)
        {
            return _minutes / GetDistance();
        }
        else
        {
            return 0.0;
        }
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} min) - Laps: {_laps}, Distance {GetDistance().ToString("0.0")} km, Speed {(GetSpeed()).ToString("0.0")} kph, Pace: {(GetPace() * 60).ToString("0.0")} min per km";
    }
}