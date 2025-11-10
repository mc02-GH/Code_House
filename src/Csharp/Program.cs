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
        Random ran = new Random();

        while (true)
        {
            int z = ran.Next(1, 20);

            while (z > 1)
            {
                Console.Write(" ");
                z--;


            }
            Console.Write(x);

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
