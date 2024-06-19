using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square("blue", 4);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Yellow", 4, 3);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Red", 5);
        shapes.Add(circle1);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


    }


}