namespace ExercicioTabuadaFor;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Tabuada com For =====");
        Console.WriteLine("Digite um número de tabuada de 1 a 10: ");
        int tabuada = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabuada do {tabuada}: ");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i * tabuada);
        }

        Console.WriteLine("Obrigada por utilizar a nossa tabuada online!");
    }
}