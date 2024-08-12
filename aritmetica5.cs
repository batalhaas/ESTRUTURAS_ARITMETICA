using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário que digite os quatro valores
        Console.WriteLine("Digite o primeiro valor:");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor:");
        double valor3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o quarto valor:");
        double valor4 = Convert.ToDouble(Console.ReadLine());

        // Calcula a média aritmética
        double media = (valor1 + valor2 + valor3 + valor4) / 4;

        // Exibe a média aritmética
        Console.WriteLine($"A média aritmética dos valores {valor1}, {valor2}, {valor3} e {valor4} é: {media}");

        Console.ReadLine(); // Aguarda o usuário pressionar Enter para sair
    }
}