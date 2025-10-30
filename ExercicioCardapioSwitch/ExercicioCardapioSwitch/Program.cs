namespace ExercicioCardapioSwitch;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Cardápio =====");
        Console.WriteLine("Veja só o nosso Menu: \n1 - Pizza  \n2 - Hambúrguer \n3 - Salada \n4 - Sair");
        Console.WriteLine("Agora digite a sua escolha: ");

        int order = Convert.ToInt32(Console.ReadLine());

        switch (order)
        {
            case 1:
                Console.WriteLine("Vocês escolheu Pizza!");
                break;

            case 2:
                Console.WriteLine("Você escolheu o hambúguer!");
                break;

            case 3:
                Console.WriteLine("Você escolheu a salada!");
                break;

            case 4:
                Console.WriteLine("Saindo...");
                    break;

            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }
}