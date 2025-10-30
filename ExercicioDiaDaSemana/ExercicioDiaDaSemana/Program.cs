namespace ExercicioDiaDaSemana;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Dias da semana =====");
        Console.WriteLine("Escolha um dia da semana: \n1 - Domingo \n2 - Segunda-feira \n3 - Terça-feira \n4 - Quarta-feira \n5 - Quinta-feira \n6 - Sexta-feira \n7 - Sábado");

        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;

            case 2:
                Console.WriteLine("Segunda-feira");
                break;

            case 3:
                Console.WriteLine("Terça-feira");
                break;

            case 4:
                Console.WriteLine("Quarta-feira");
                break;

            case 5:
                Console.WriteLine("Quinta-feira");
                break;

            case 6:
                Console.WriteLine("Sexta-feira");
                break;

            case 7:
                Console.WriteLine("Sábado");
                break;

            default:
                Console.WriteLine("Dia da semana inválido.");
                break;
        }
    }

}