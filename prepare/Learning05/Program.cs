using System;

class Program
{
    static void Main(string[] args)
    {
        // square
        Square shape1 = new Square("red", 3);
        Console.WriteLine($"The square is {shape1.GetColor()}, and the area is {shape1.GetArea()}");
    
        // rectangle
        Rectangle shape2 = new Rectangle("blue", 3, 8);
        Console.WriteLine($"The rectangle is {shape2.GetColor()}, and the area is {shape2.GetArea()}");
    
        // circle
        Circle shape3 = new Circle("green", 5);
        Console.WriteLine($"The circle is {shape3.GetColor()}, and the area is {shape3.GetArea()}");
    
        // list
        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes) {
            string col = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The color is {col}, and the area is {area}");
        }
    }
}