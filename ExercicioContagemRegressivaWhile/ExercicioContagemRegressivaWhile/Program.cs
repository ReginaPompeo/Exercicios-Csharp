namespace ExercicioContagemRegressivaWhile;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Contagem Regressiva =====");
        Console.WriteLine("Digite um número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        while (number != 0) 
        {
            Console.WriteLine(number);
            --number;
        }
        Console.WriteLine("0 \nFim!");
    } 
}
