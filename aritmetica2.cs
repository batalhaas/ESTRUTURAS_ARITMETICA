using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculoAreaQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da aresta do quadrado:");
            string input = Console.ReadLine(); // Lê o valor digitado pelo usuário como uma string
            double aresta;

            // Tenta converter a entrada do usuário em um número do tipo double
            if (double.TryParse(input, out aresta))
            {
                // Verifica se o valor da aresta é positivo
                if (aresta > 0)
                {
                    // Calcula a área do quadrado
                    double area = Math.Pow(aresta, 2);
                    Console.WriteLine($"A área do quadrado com aresta {aresta} é: {area}");
                }
                else
                {
                    Console.WriteLine("O valor da aresta deve ser maior que zero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }

            Console.ReadLine(); // Mantém o console aberto até que o usuário pressione Enter
        }
    }
}