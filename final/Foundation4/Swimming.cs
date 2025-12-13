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
        return GetDistance() != 0 ? GetDistance() / _minutes * 60 : 0.0;
    }

    public override double GetPace()
    {
        return GetDistance() != 0 ? _minutes / GetDistance() : 0.0;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} min) - Laps: {_laps}, Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
