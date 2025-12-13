class Cycling : Activity
{
    protected double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * _minutes / 60;
    }

    public override double GetPace()
    {
        return GetDistance() != 0 ? _minutes / GetDistance() : 0.0;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes} min) - Distance {GetDistance():0.0} km, Speed {_speed:0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
