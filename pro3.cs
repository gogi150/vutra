using System;

public class Program
{
   public static void Main()
    {
        Console.WriteLine("Unesite rečenicu:");
        string recenica = Console.ReadLine();

        string[] rijeci = recenica.Split(' ');

        Console.WriteLine("Prva riječ: " + rijeci[0]);
        Console.WriteLine("Zadnja riječ: " + rijeci[rijeci.Length - 1]);
    }
}