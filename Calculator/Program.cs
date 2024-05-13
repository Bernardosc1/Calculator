using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            menu(valor1, valor2);
        }

        static void menu(float valor1, float valor2)
        {
            Console.WriteLine("Escolha uma das seguintes operações: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------------");
            Console.WriteLine("Escolha uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Console.WriteLine(Soma(valor1, valor2)); break;
                case 2: Console.WriteLine(Subtracao(valor1, valor2)); break;
                case 3: Console.WriteLine(Multiplicacao(valor1, valor2)); break;
                case 4: Console.WriteLine(Divisao(valor1, valor2)); break;
                case 5:  Console.WriteLine("Saindo..."); System.Environment.Exit(0); break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        }

        static double Soma(float valor1, float valor2)
        {
            double resultado = valor1 + valor2;
            return resultado;

        }

        static double Subtracao(float valor1, float valor2)
        {
            double resultado = valor1 - valor2;
            return resultado;
        }

        static double Multiplicacao(float valor1, float valor2)
        {
            double resultado = valor1 * valor2;
            return resultado;
        }

        static double Divisao(float valor1, float valor2)
        {
            double resultado = valor1 / valor2;
            return resultado;
        }
    }
}
