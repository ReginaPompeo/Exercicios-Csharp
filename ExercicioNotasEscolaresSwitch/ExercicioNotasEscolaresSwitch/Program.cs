using System.Globalization;

namespace ExercicioNotasEscolaresSwitch;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Notas Escolares =====");
        Console.WriteLine("Digite a sua nota (A, B, C, D, F): ");

        String note = Console.ReadLine();

        switch (note)
        {
            case "A":
                Console.WriteLine("Excelente!");
                break;

            case "B":
                Console.WriteLine("Bom");
                break;

            case "C":
                Console.WriteLine("Regular");
                break;

            case "D":
                Console.WriteLine("Ruim");
                break;

            case "F":
                Console.WriteLine("Reprovado");
                break;

            default:
                Console.WriteLine("Nota inválida.");
                break;
        }
    }
}

