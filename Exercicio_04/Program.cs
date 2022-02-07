using System;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double numero = int.Parse(Console.ReadLine());  

            if ((numero%2 == 0)) {
                Console.WriteLine("Número par!");
            } else
            {
                Console.WriteLine("Número impar.");
            }
        }
    }
}
