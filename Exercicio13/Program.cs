using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int numero;

                // Solicita ao usuário que insira o valor para calcular o fatorial
                while (true)
                {
                    Console.Write("Digite um número para calcular o fatorial: ");
                    if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
                    {
                        Console.WriteLine("Valor inválido. Por favor, digite um número inteiro não negativo.");
                    }
                    else
                    {
                        break;
                    }
                }

                // Calcula o fatorial do número
                long fatorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }

                // Exibe o resultado
                Console.WriteLine($"O fatorial de {numero} é: {fatorial}");

                // Pergunta ao usuário se ele deseja fazer um novo cálculo
                Console.Write("Deseja calcular o fatorial de outro número? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();

                // Verifica se a resposta é válida e encerra ou continua a execução do programa
                if (resposta != "S")
                {
                    break;
                }

            } while (true);
        }
    }
}
