using System;

abstract class Shape
{
  public abstract double GetArea();
}

class Circle : Shape
{
  public double Radius { get; set; }

  public Circle(double radius)
  {
    Radius = radius;
  }

  public override double GetArea()
  {
    return Math.PI * Radius * Radius;
  }
}

class Rectangle : Shape
{
  public double Width { get; set; }
  public double Height { get; set; }

  public Rectangle(double width, double height)
  {
    Width = width;
    Height = height;
  }

  public override GetArea()
  {
    return Width * Height;
  }
}

class AbstractShapeDemo
{
  public static void Main(string[] args)
  {
    Circle circle = new Circle(5);
    Rectangle rectangle = new Rectangle(10, 13);

    Console.WriteLine($"Area of a circle: {circle.GetArea()}");
    Console.WriteLine($"Area of a Rectangle: {rectangle.GetArea()}");
  }
}