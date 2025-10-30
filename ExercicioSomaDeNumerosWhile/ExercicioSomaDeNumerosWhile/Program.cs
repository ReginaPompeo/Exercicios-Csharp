namespace ExercicioSomaDeNumerosWhile;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Soma de número com While");
        Console.WriteLine("Digite um número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sumOthers = number;

        while (number != 0)
        {
            Console.WriteLine("Digite um número: ");
            number = Convert.ToInt32(Console.ReadLine());
            sumOthers = number + sumOthers;
        }

        Console.WriteLine("Parabéns! Você chegou ao número 0, a soma das tentativas foi: " + sumOthers);
    }
}