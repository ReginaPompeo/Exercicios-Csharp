namespace DesafioCaixaEletronico;

public class Program
{
    public static void Main()
    {
        double balance = 1000;

        Console.WriteLine("===== Caixa Eletrônico =====");
        Console.WriteLine("1 - Ver saldo \n2 - Depositar \n3 - Sacar \n4 - Sair");
        int option = Convert.ToInt32(Console.ReadLine());

        while (option != 4)
        {
            switch (option) 
            {
                case 1: 
                    Console.WriteLine(balance);
                    break;

                case 2:
                    Console.WriteLine("Qual valor deseja depositar?");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    balance = balance + deposit;
                    break;

                case 3:
                    Console.WriteLine("Qual valor deseja sacar?");
                    double withdrawMoney = Convert.ToDouble(Console.ReadLine());
                    balance = balance - withdrawMoney;
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

            Console.WriteLine("1 - Ver saldo \n2 - Depositar \n3 - Sacar \n4 - Sair");
            option = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Obrigada por usar nosso caixa eletrônico!");

    }
}
