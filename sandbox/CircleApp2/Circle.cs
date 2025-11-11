class Circle
{
    public double _radius;
    public void SetRadious(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Invalid radius, must >= 0.0");
            _radius = 0;
        }
        else
        {
            _radius = radius;
        }
    }

    public double GetCircleArea()
    {
        return 3.1415 * _radius * _radius;
    }
}