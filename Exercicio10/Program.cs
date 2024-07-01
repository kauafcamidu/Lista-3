using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int quantidadeValores = 10;
            double maiorValor = double.MinValue;
            double soma = 0;

            // Solicita ao usuário que insira os valores
            for (int i = 0; i < quantidadeValores; i++)
            {
                double valor;

                // Loop para garantir que o valor inserido seja positivo
                while (true)
                {
                    Console.Write($"Digite o {i + 1}º valor positivo: ");
                    if (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                    {
                        Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                    }
                    else
                    {
                        break;
                    }
                }

                // Atualiza o maior valor
                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }

                // Soma os valores
                soma += valor;
            }

            // Calcula a média aritmética
            double media = soma / quantidadeValores;

            // Exibe os resultados
            Console.WriteLine($"Maior valor inserido: {maiorValor}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Média aritmética dos valores: {media}");
        }
    }
}
