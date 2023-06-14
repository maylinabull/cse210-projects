using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq = new Square("orange", 2);
        shapes.Add(sq);


        Rectangle r = new Rectangle("blue", 10, 10);
        shapes.Add(r);

        Circle c = new Circle("red", 5);
        shapes.Add(c);


        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}