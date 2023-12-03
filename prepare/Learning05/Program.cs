using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("blue", 5);
      

        Rectangle rectangle1 = new Rectangle("red", 6, 5);
        

        Circle circle1 = new Circle("Orange",5);
        
        
        List<Shape> shapes = new List<Shape>();

        shapes.Add(circle1);
        shapes.Add(rectangle1);
        shapes.Add(square1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");

        }

        



        
    }
}