using System.Runtime.Serialization;

namespace ExercicioMediaDeValoresFor;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Média de valores =====");

        int soma = 0;
        int quantidade = 5;

        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine($"Digite o {i}º número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            soma += numero;
        }

        double media = (double)soma / quantidade;
        Console.WriteLine($"A média dos {quantidade} números é: {media}");
    }
}
