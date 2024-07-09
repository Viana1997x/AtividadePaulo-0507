using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvaav
{
    public class NumerosContas
    {

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");
                Console.Write("Opção: ");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 5)
                {
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"Resultado da adição: {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Resultado da subtração: {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"Resultado da multiplicação: {resultado}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado da divisão: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
