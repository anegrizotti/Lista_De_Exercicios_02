using System;


// Escreva um algoritmo que leia três valores inteiros e diferentes e
//mostre - os em ordem decrescente.

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int maior = 0, meio = 0, menor = 0;

            Console.WriteLine("Insira um valor inteiro para A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor inteiro para B, que seja diferente A: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor inteiro para C, que seja diferente de A e B: ");
            int c = int.Parse(Console.ReadLine());

            while (a == b || a == c || b == c)
            {
                Console.WriteLine("Os três valores digitados precisam ser diferentes. Por favor, digite novamente.");
                Console.WriteLine("Insira um valor inteiro para A: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira um valor inteiro para B, que seja diferente A: ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira um valor inteiro para C, que seja diferente de A e B: ");
                c = int.Parse(Console.ReadLine());

            }

            if (a > b && a > c) 
            {
                maior = a;            
            }

            if (a < b && a > c || a < c && a > b)
            {
                meio = a;
            }

            if (a < b && a < c)
            {
                menor = a;
            }

            if (b > a && b > c)
            {
                maior = b;
            }

            if (b < a && b > c || b > a && b < c)
            {
                meio = b;
            }

            if (b < a && b < c)
            {
                menor = b;
            }

            if (c > b && c > a)
            {
                maior = c;
            }

            if (c < b && c > a || c > b && c < a)
            {
                meio = c;
            }

            if (c < b && c < a)
            {
                menor = c;
            }

            Console.WriteLine("Ordem decrescente dos números: " + maior + " " + meio + " " + menor);

        }
    }
}
