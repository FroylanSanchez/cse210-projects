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
        return $"{_date} Cycling ({_minutes} min) - Distance {GetDistance().ToString("0.0")} km, Speed {_speed.ToString("0.0")} kph, Pace: {(GetPace() * 60).ToString("0.0")} min per km";
    }
}