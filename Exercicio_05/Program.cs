using System;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int c = 0;

            Console.WriteLine("Digite um valor inteiro para A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro para B: ");
            int b = int.Parse(Console.ReadLine());

            if (a==b)
            {
                c = a + b;
                Console.WriteLine("A + B = "+c);
            } else
            {
                c = a * b;
                Console.WriteLine("A * B = " + c);
            }

        }
    }
}
