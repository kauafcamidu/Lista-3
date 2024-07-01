using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int numero = 1; numero <= 20; numero++)
            {
                Console.WriteLine($"Tabuada do número {numero}:");

                // Loop para exibir a tabuada do número atual no intervalo de 1 a 10
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }

                // Solicita que o usuário pressione uma tecla para continuar
                Console.WriteLine("Pressione qualquer tecla para continuar para a próxima tabuada...");
                Console.ReadKey();
                Console.WriteLine(); // Adiciona uma linha em branco para separar as tabuadas
            }
        }
    }
}
    

