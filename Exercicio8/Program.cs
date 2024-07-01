using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            // Loop para somar os números de 1 a 100
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }

            // Exibe a soma total
            Console.WriteLine($"A soma dos números inteiros positivos de 1 a 100 é: {soma}");
        }
    }
}
    

