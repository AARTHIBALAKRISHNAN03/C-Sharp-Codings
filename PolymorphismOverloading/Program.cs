using System;

public class MathOperations
{
    
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

  
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathOperations math = new MathOperations();

        
        int result1 = math.Add(5, 3);
        int result2 = math.Add(10, 20, 30);
        double result3 = math.Add(2.5, 3.7);

        Console.WriteLine("Result1: " + result1); 
        Console.WriteLine("Result2: " + result2); 
        Console.WriteLine("Result3: " + result3); 
    }
}