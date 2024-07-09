using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV6_7
{
    public class NumerosInteiros
    {
        static void Main()
            {
                while (true)
                {
                    Console.WriteLine("Digite dois números inteiros:");

                    Console.Write("Primeiro número: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nEscolha uma opção:");
                    Console.WriteLine("1. Verificar se um dos números é ou não múltiplo do outro");
                    Console.WriteLine("2. Verificar se os dois números lidos são pares");
                    Console.WriteLine("3. Verificar se a média dos números é maior ou igual a 7");
                    Console.WriteLine("4. Sair do programa");
                    Console.Write("Opção: ");

                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            if (num1 % num2 == 0 || num2 % num1 == 0)
                            {
                                Console.WriteLine("Um dos números é múltiplo do outro.");
                            }
                            else
                            {
                                Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                            }
                            break;
                        case 2:
                            if (num1 % 2 == 0 && num2 % 2 == 0)
                            {
                                Console.WriteLine("Ambos os números são pares.");
                            }
                            else
                            {
                                Console.WriteLine("Os números não são ambos pares.");
                            }
                            break;
                        case 3:
                            double media = (num1 + num2) / 2.0;
                            if (media >= 7)
                            {
                                Console.WriteLine($"A média dos números é {media}, que é maior ou igual a 7.");
                            }
                            else
                            {
                                Console.WriteLine($"A média dos números é {media}, que é menor que 7.");
                            }
                            break;
                        case 4:
                            return; // Encerra o programa
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                    Console.WriteLine();
                }
            }
        }
    }
