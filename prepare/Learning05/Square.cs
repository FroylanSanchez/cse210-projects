public class SquareShape : Shape
{
        private double _side;

    public SquareShape(string color, double side) : base (color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}
