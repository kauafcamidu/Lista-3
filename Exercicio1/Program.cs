using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = -1;

            // Solicita ao usuário para entrar com a nota P1 e garante que o valor seja positivo
            while (p1 < 0)
            {
                Console.Write("Digite a nota da P1 (valor positivo): ");
                p1 = Convert.ToDouble(Console.ReadLine());

                if (p1 < 0)
                {
                    Console.WriteLine("Nota inválida. Por favor, digite um valor positivo.");
                }
            }

            // A média de aprovação
            double mediaAprovacao = 5.0;

            // Calcula a nota necessária em P2 para que a média seja igual a 5.0
            double p2Necessaria = (3 * mediaAprovacao - p1) / 2;

            // Exibe a nota necessária para P2
            Console.WriteLine($"Para ser aprovado, você precisa tirar pelo menos {p2Necessaria:F2} na P2.");
        }
    }
    }
}
