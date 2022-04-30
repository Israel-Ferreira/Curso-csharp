using System;
using System.Globalization;

namespace OutputCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDouble = 34.99982;

            Console.WriteLine(numeroDouble); // Imprimindo o Número sem a formatação da quantidade de casas decimais
            Console.WriteLine(numeroDouble.ToString("F2")); // Imprimindo o Número com duas casas decimais

            Console.WriteLine(numeroDouble.ToString("F2", CultureInfo.InvariantCulture));
            
            string nome = "Israel";
            int idade = 22;


            Console.WriteLine("O funcionario {0} tem {1} anos", nome, idade);

        }
    }
}
