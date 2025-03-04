// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

public class Calculator
{
    public Calculator() { }

    public int add(int a, int b)
    {
        return a + b;
    }

    public int substract(int a, int b)
    {
        return a - b;
    }

    public int divide(int a, int b)
    {
        try
        {
            return a / b;
        } catch {
            Console.WriteLine("Cant divide by 0.");
            return 0;
        }
    }

    public int multiply(int a, int b)
    {
        return a * b;
    }
}