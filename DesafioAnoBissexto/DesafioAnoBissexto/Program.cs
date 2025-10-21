namespace DesafioAnoBissexto;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========== Bem-vindo ao verificador de ano bissexto ==========");
        Console.WriteLine("Digite o número do ano que deseja verificar: ");

        int year = Convert.ToInt32(Console.ReadLine());


        if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("Ano bissexto!");
        } else
        {
            Console.WriteLine("Esse ano NÃO é bissexto.");
        }
    }
}