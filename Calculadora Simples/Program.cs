using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Simples
{
    internal class Program
    {
        enum Options { Somar = 1, Subtrair, Dividir, Multiplicar };

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione sua opção: ");
            Console.WriteLine(" 1 - Somar\n 2 - Subtrair\n 3 - Dividir\n 4 - Multiplicar");

            int index = int.Parse(Console.ReadLine());
            Options optionSelected = (Options)index;

            PerformOperation(optionSelected);

            Console.ReadLine();
        }

        static void PerformOperation(Options option)
        {
            int valueOne = int.Parse(Console.ReadLine());
            int valueTwo = int.Parse(Console.ReadLine());
            int result = 0;

            switch (option)
            {
                case Options.Somar:
                    Console.WriteLine("Você está somando");
                    result = Somar(valueOne, valueTwo);
                    break;
                case Options.Subtrair:
                    Console.WriteLine("Você está subtraindo");
                    result = Subtrair(valueOne, valueTwo);
                    break;
                case Options.Dividir:
                    Console.WriteLine("Você está dividindo");
                    result = Dividir(valueOne, valueTwo);
                    break;
                case Options.Multiplicar:
                    Console.WriteLine("Você está multiplicando");
                    result = Multiplicar(valueOne, valueTwo);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("O resultado do valor é: " + result);
        }

        static int Somar(int a, int b) => a + b;
        static int Subtrair(int a, int b) => a - b;
        static int Dividir(int a, int b) => a / b;
        static int Multiplicar(int a, int b) => a * b;
    }

}
