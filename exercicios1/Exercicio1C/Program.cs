// See https://aka.ms/new-console-template for more information
using System;

namespace Exercicio1C
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Informe o primeiro numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro numero: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o quarto numero: ");
            d = Convert.ToInt32(Console.ReadLine());

            double diff = (a * b) - (c * d);

            Console.WriteLine($"DIFERENCA={diff}");
 
        }
    }
}