using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor (valor positivo): ");
            double primeiroValor = Convert.ToDouble(Console.ReadLine());

            // Verifica se o primeiro valor é positivo
            while (primeiroValor <= 0)
            {
                Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                Console.Write("Digite o primeiro valor (valor positivo): ");
                primeiroValor = Convert.ToDouble(Console.ReadLine());
            }

            double segundoValor;

            // Solicita ao usuário para entrar com o segundo valor, garantindo que seja maior que o primeiro
            do
            {
                Console.Write("Digite o segundo valor (deve ser maior que o primeiro valor): ");
                segundoValor = Convert.ToDouble(Console.ReadLine());

                if (segundoValor <= primeiroValor)
                {
                    Console.WriteLine("Valor inválido. O segundo valor deve ser maior que o primeiro valor.");
                }
            } while (segundoValor <= primeiroValor);

        }

    }
