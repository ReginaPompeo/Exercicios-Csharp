using System.Diagnostics;

namespace ExercicioSenhaWhile;

public class Program
{
    public static void Main()
    {
        string user = "Regina";
        string password = "1234";

        Console.WriteLine("===== Login e senha =====");

        Console.WriteLine("Digite seu nome de usuário: ");
        string userAnswer = Console.ReadLine();

        Console.WriteLine("Digite a sua senha: ");
        string passwordAnswer = Console.ReadLine();


        while (userAnswer != user || passwordAnswer != password)
        {
            Console.WriteLine("Usuário ou senha incorretos. Tente novamente!");

            Console.WriteLine("Digite seu nome de usuário: ");
            userAnswer = Console.ReadLine();

            Console.WriteLine("Digite a sua senha: ");
            passwordAnswer = Console.ReadLine();

        }
        Console.WriteLine("Você está logado!");
    }
}
