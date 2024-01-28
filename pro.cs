using System;

public class Program
{
    public static void Main()
    {
        double a = 2;
        double b = 3;
        double c = 4;
        double d = 5;

        double x = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)) / (Math.Pow(a + b, 2) + Math.Pow(c + d, 2));

        Console.WriteLine(x);
    }
}