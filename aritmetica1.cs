using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double baseRetangulo, alturaRetangulo;

        // Solicitar e ler a entrada da base do retângulo
        Console.Write("Digite o valor da base do retângulo: ");
        baseRetangulo = Convert.ToDouble(Console.ReadLine());

        // Solicitar e ler a entrada da altura do retângulo
        Console.Write("Digite o valor da altura do retângulo: ");
        alturaRetangulo = Convert.ToDouble(Console.ReadLine());

        // Calcular a área do retângulo
        double areaRetangulo = baseRetangulo * alturaRetangulo;

        // Exibir a área calculada
        Console.WriteLine($"A área do retângulo é: {areaRetangulo}");

        // Aguardar que o usuário pressione uma tecla para sair
        Console.ReadKey();
    }
}