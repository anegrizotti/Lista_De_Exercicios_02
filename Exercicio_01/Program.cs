using System;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor para A: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor para B: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor para C: ");
            double c = double.Parse(Console.ReadLine());

            double soma = a + b;

            if (soma < c)
            {
                Console.WriteLine("A soma de A + B é menor do que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior do que C.");
            }

        }
    }
}
