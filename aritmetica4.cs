using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo, alturaTriangulo, areaTriangulo;

            // Solicita e lê a base do triângulo
            Console.WriteLine("Digite o valor da base do triângulo:");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());

            // Solicita e lê a altura do triângulo
            Console.WriteLine("Digite o valor da altura do triângulo:");
            alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // Calcula a área do triângulo
            areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            // Exibe a área do triângulo
            Console.WriteLine("A área do triângulo é: " + areaTriangulo);

            Console.ReadLine(); // Mantém a janela aberta até que o usuário pressione Enter
        }
    }
}