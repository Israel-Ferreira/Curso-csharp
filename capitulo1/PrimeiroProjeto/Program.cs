using System;

namespace PrimeiroProjeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            sbyte n1 = -127;
            short n2 = -32768;

            byte n3 = 255; // Tipo Byte (Somente números Positivos de 0 a 255)
            int valorInt = 10000; // Tipo Inteiro

            long n4 = 2147483648455L;

            n3++;

            Console.WriteLine($"{n1}: {n1.GetType()}");
            Console.WriteLine($"{n2}");

            Console.WriteLine($"Overflow: {n3}");

            Console.WriteLine($"{valorInt * 2}, Tipo {valorInt.GetType()}");

            Console.WriteLine($"Valor long: {n4}, Tipo: {n4.GetType()}");
        }
    }
}