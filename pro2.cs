using System;

public class Program
{
   public static void Main()
    {
        string s1 = "Hrvatska ima more";
        string s2 = "Italija je prvak svijeta";

        string s3 = s1.Substring(0, 7) + s2.Substring(6);

        Console.WriteLine(s3);
    }
}