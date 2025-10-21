namespace ExercicioMaiorDeTres;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("====== Verificador de qual número é maior =======");
        Console.WriteLine("Digite o primeiro número: ");

        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");

        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número: ");

        int number3 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine("O número " + number1 + " é o maior.");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine("O número " + number2 + " é o maior.");
        }
        else
        {
            Console.WriteLine("O número " + number3 + " é o maior.");
        }
    }
}