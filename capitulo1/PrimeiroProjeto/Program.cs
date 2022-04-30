using System;

namespace PrimeiroProjeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            sbyte n1 = -127;
            short n2 = -32768;

            byte n3 = 255;

            n3++;

            Console.WriteLine($"{n1}: {n1.GetType()}");
            Console.WriteLine($"{n2}");

            Console.WriteLine($"Overflow: {n3}");

            Console.WriteLine("Hello, World!");
        }
    }
}