using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace ExercicioLoginSimples
{
    public class Program
    {
        public static void Main ()
        {
            string user = "ReginaP";
            string password = "Regina123";

            Console.WriteLine("========== Bem-vindo ao nosso aplicativo ==========");
            Console.WriteLine("Primeiro faça seu login");
            Console.WriteLine("Insira seu nome de usuário: ");

            string userAnswer = Console.ReadLine();

            Console.WriteLine("Agora insira a sua senha: ");

            string passwordAnswer = Console.ReadLine();

            if (userAnswer == user && passwordAnswer == password)
            {
                Console.WriteLine("Seu login foi realizado!");
            } else if (userAnswer == user && passwordAnswer != password)
            {
                Console.WriteLine("Essa senha é inválida");      
            } else
            {
                Console.WriteLine("Usuário e senha inválidos.");
            }



        }
    }
}
