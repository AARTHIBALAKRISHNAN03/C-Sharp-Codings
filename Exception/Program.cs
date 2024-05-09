using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            
            int result = num1 / num2;

            Console.WriteLine("Average: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integer numbers.");
        }
        
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero. Please enter a non-zero number as the second number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}