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
            Console.WriteLine("Digite o valor da diagonal do quadrado:");
            double diagonal = Convert.ToDouble(Console.ReadLine());

            // Calculando o lado do quadrado utilizando o teorema de Pitágoras
            double lado = diagonal / Math.Sqrt(2);

            // Calculando a área do quadrado
            double area = lado * lado;

            Console.WriteLine($"A área do quadrado é: {area}");
        }
    }
}