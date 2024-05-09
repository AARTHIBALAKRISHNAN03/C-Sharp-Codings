using System;


public abstract class Shape
{
    
    public abstract double CalculateArea();
}


public class Circle : Shape
{
    private double radius;

  
    public Circle(double radius)
    {
        this.radius = radius;
    }

    
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}


public class Rectangle : Shape
{
    private double width;
    private double height;

  
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    
    public override double CalculateArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        
        
        Console.WriteLine("Area of Circle: " + circle.CalculateArea());
        Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
    }
}
