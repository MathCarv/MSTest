using System;

namespace CalculatorApp
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecione o tipo de operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.Write("Opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case 1:
                    resultado = Calculator.Soma(num1, num2);
                    Console.WriteLine($"Resultado da soma: {resultado}");
                    break;
                case 2:
                    resultado = Calculator.Subtracao(num1, num2);
                    Console.WriteLine($"Resultado da subtração: {resultado}");
                    break;
                case 3:
                    resultado = Calculator.Multiplicacao(num1, num2);
                    Console.WriteLine($"Resultado da multiplicação: {resultado}");
                    break;
                case 4:
                    try
                    {
                        resultado = Calculator.Divisao(num1, num2);
                        Console.WriteLine($"Resultado da divisão: {resultado}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Erro: " + ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
