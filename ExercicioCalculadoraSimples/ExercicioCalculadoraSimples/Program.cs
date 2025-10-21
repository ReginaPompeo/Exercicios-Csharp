namespace ExercicioCalculadoraSimples;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("======== Bem-vindo a nossa calculadora ========");
        Console.WriteLine("Digite um número: ");

        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro número: ");

        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Agora digite a operação (+, -, *, /): ");

        string operation = Console.ReadLine();

        if (operation == "+")
        {
            Console.WriteLine(number1 + number2);
        }
        else if (operation == "-")
        {
            Console.WriteLine(number1 - number2);
        }
        else if (operation == "*")
        {
            Console.WriteLine(number1 * number2);
        }
        else if (operation == "/")
        {
            Console.WriteLine(number1 / number2);
        }
        else
        {
            Console.WriteLine("Digite um operador válido.");
        }

    }
}