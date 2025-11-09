using System;
using System.Linq;

namespace Csapp;

public static class Program
{
    public static void a()
    {
        Console.WriteLine("\nEnter string");
        var x = Console.ReadLine();
        string y;
        while (true)
        {
            y = "  ";
            Console.Write(y + x);
            y = " ";
            Console.Write(y + x);
            y = "   ";
            Console.Write(y + x);


        }
    }
    public static void Main()
    {
        while (true)
        {
            a();
        }

    }
}
