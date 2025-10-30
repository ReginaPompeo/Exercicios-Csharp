namespace ExercicioFatorialFor;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Digite um número fatorial =====");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int fatorial = 1;

        for (int i = number1; i >= 1; i--)
        {
            fatorial *= i;
        }
        Console.WriteLine($"O fatorial de {number1} é: {fatorial}");
    }
}