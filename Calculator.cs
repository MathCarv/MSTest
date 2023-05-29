using System;

namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("-------------------");

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecione a operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");

            Console.Write("Digite o número da operação desejada: ");
            int operacao = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = Calculator.Soma(num1, num2);
                    Console.WriteLine($"O resultado da soma é: {resultado}");
                    break;
                case 2:
                    resultado = Calculator.Subtracao(num1, num2);
                    Console.WriteLine($"O resultado da subtração é: {resultado}");
                    break;
                case 3:
                    resultado = Calculator.Multiplicacao(num1, num2);
                    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                    break;
                case 4:
                    resultado = Calculator.Divisao(num1, num2);
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public static double Soma(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtracao(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplicacao(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divisao(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
