using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();
        SquareShape shape1 = new SquareShape("Purple", 5);
        shapes.Add(shape1);
        RectangularShape shape2 = new RectangularShape("Yellow", 2, 9);
        shapes.Add(shape2);
        CircularShape shape3 = new CircularShape("Brown", 6);
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}