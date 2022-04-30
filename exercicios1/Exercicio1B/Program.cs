// See https://aka.ms/new-console-template for more information
using System;

namespace Exercicio1B
{
    class Program
    {
        static void Main(string[] args)
        {
           const double PI = 3.14159;

           double raio;

           Console.WriteLine("Informe o raio do circulo: ");
           raio = Convert.ToDouble(Console.ReadLine());

           double areaCirculo =  PI * (Math.Pow(raio, 2));

           Console.WriteLine($"A área do circulo é: {areaCirculo} m**2");
        }
    }
}