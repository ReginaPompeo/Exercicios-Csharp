namespace ExercicioSomaDeNumerosFor;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Soma de números de 1 a 100 =====");

        int soma = 0;

        for (int i = 1; i <= 100; i++)
        {
            soma += i;

        }
        Console.WriteLine($"A soma é de {soma}");
    }
}