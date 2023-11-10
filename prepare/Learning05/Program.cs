using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 5);
        Circle circle = new Circle("blue", 5);
        Rectangle rectangle = new Rectangle("green", 5, 10);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetColor()} shape is {shape.GetArea()}");
        }
    }
}