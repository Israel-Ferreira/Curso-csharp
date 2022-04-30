using System;


namespace Exercicio1D
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorPorHora;

            int horasTrabalhadas;

            Console.WriteLine("Informe o número/inscrição do funcionario: ");
            string inscrição = Console.ReadLine();

            Console.WriteLine("Informe as horas trabalhadas pelo funcionario: ");
            horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor pago por hora para o funcionario: ");
            valorPorHora = Convert.ToDouble(Console.ReadLine());


            double salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine($"O funcionario com a inscrição {inscrição} recebera: R$ {salario}");

        }
    }
}
