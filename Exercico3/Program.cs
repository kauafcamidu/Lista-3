using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;

            // Solicita ao usuário para entrar com o sexo, garantindo que seja "F" ou "M"
            while (true)
            {
                Console.Write("Digite o sexo (F para feminino, M para masculino): ");
                sexo = Console.ReadLine().ToUpper();

                if (sexo == "F" || sexo == "M")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite 'F' para feminino ou 'M' para masculino.");
                }
            }

            // Exibe o sexo válido inserido
            Console.WriteLine($"Sexo inserido: {sexo}");
        }
    }
}
