namespace ExercicioOperacaoMatematicaSwitch;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Operação matemática =====");
        Console.WriteLine("Digite o primeiro valor: ");

        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");

        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite qual é o tipo de operação que deseja fazer: \n1 - Adição (+) \n2 - Subtração (-) \n3 - Multiplicação (*) \n4 - Divisão (/) ");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation) 
        {
            case 1:
                Console.WriteLine(number1 + number2);
                break;

            case 2:
                Console.WriteLine(number1 - number2);
                break;

            case 3:
                Console.WriteLine(number1 * number2);
                break;

            case 4:
                Console.WriteLine(number1 / number2);
                break;

            default:
                Console.WriteLine("Operação inválida");
                break;
        }

    }
}
