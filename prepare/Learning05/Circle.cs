public class CircularShape : Shape
{
    private double _radius;

    public CircularShape(string color, double radius) : base (color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}