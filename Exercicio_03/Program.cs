using System;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso, em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura, em m: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura*altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso!");
            } else if (imc >= 18.5 && imc <= 25)
                {
                Console.WriteLine("Peso normal!");
            } else if (imc >= 25 && imc <= 30)
            {
                Console.WriteLine("Acima do peso!");
            } else
            {
                Console.WriteLine("Obeso!");
            }

        }
    }
}
