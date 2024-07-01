using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeValores;

            // Solicita ao usuário que insira a quantidade de valores (N)
            while (true)
            {
                Console.Write("Digite a quantidade de valores (N) (positiva, mas menor que vinte): ");
                if (!int.TryParse(Console.ReadLine(), out quantidadeValores) || quantidadeValores <= 0 || quantidadeValores >= 20)
                {
                    Console.WriteLine("Quantidade inválida. Por favor, digite um valor positivo, mas menor que vinte.");
                }
                else
                {
                    break;
                }
            }

            // Declaração das variáveis para rastrear os valores
            double maiorValor = double.MinValue;
            double menorValor = double.MaxValue;
            double soma = 0;
            int positivos = 0;
            int negativos = 0;

            // Solicita ao usuário que insira os valores e realiza os cálculos
            for (int i = 0; i < quantidadeValores; i++)
            {
                double valor;

                Console.Write($"Digite o {i + 1}º valor: ");
                if (!double.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número.");
                    i--; // Permite ao usuário tentar novamente inserir o valor atual
                    continue;
                }

                // Calcula o maior valor
                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }

                // Calcula o menor valor
                if (valor < menorValor)
                {
                    menorValor = valor;
                }

                // Soma os valores
                soma += valor;

                // Conta os valores positivos e negativos
                if (valor > 0)
                {
                    positivos++;
                }
                else if (valor < 0)
                {
                    negativos++;
                }
            }

            // Calcula a média aritmética
            double media = soma / quantidadeValores;

            // Calcula a porcentagem de valores positivos e negativos
            double porcentagemPositivos = (double)positivos / quantidadeValores * 100;
            double porcentagemNegativos = (double)negativos / quantidadeValores * 100;

            // Exibe os resultados
            Console.WriteLine($"Maior valor inserido: {maiorValor}");
            Console.WriteLine($"Menor valor inserido: {menorValor}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Média aritmética dos valores: {media}");
            Console.WriteLine($"Porcentagem de valores positivos: {porcentagemPositivos}%");
            Console.WriteLine($"Porcentagem de valores negativos: {porcentagemNegativos}%");
        }
    }
}
