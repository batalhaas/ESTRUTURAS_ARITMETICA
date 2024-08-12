using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMediaGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double mediaGeometrica = CalculaMediaGeometrica(valor1, valor2);

            Console.WriteLine("A média geométrica de " + valor1 + " e " + valor2 + " é: " + mediaGeometrica);
        }

        static double CalculaMediaGeometrica(double valor1, double valor2)
        {
            // Calcula a média geométrica utilizando a fórmula: sqrt(valor1 * valor2)
            double media = Math.Sqrt(valor1 * valor2);
            return media;
        }
    }
}