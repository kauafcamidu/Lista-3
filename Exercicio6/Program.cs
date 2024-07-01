using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;

            // Solicita ao usuário para entrar com um valor positivo
            while (true)
            {
                Console.Write("Digite um valor positivo: ");
                valor = Convert.ToDouble(Console.ReadLine());

                if (valor > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                }
            }

            // Exibe a tabuada do valor inserido no intervalo de um a dez
            Console.WriteLine($"Tabuada do número {valor}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{valor} x {i} = {valor * i}");
            }
        }
    }
}
    

