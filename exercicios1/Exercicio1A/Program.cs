using System;

namespace Exercicio1A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            int soma = n1 + n2;

            Console.WriteLine($"A soma dos dois números informados é: {soma}");
        }
    }
}