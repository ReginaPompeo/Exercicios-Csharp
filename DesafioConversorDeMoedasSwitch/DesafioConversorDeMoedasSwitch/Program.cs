using System.Reflection.Metadata;

namespace DesafioConversorDeMoedasSwitch;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Bem-vindo ao conversor de moedas =====");
        Console.WriteLine("Digite o valor em reais: ");
        
        double moneyReal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual a moeda que gostaria de converter (USD, EUR ou GBP): ");

        string coin = Console.ReadLine();

        switch (coin)
        {
            case "USD":
                Console.WriteLine(moneyReal * 5.50);
                break;

            case "EUR":
                Console.WriteLine(moneyReal * 6.00);
                break;

            case "GBP":
                Console.WriteLine(moneyReal * 7.00);
                break;

            default:
                Console.WriteLine("Moeda inválida");
                break;
        }
    }
}
