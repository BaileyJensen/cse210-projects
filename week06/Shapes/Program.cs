using System;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shape = new List<Shape>();
       
       Square square = new Square(5, "red");
       shape.Add(square);

       Rectangle r = new Rectangle(5,5, "orange");
       shape.Add(r);

       Circle c = new Circle(7, "pink");
       shape.Add(c);

       foreach (Shape s in shape)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


    }
}