namespace ExercicioMaioridade
{
    public class Program {

        public static void Main ()
        {
            Console.WriteLine("======= Bem-vindo ao verificador de maioridade =======");
            Console.WriteLine("Digite a sua idade: ");

            int age = Convert.ToInt32(Console.ReadLine());

            if ( age >= 18 )
            {
                Console.WriteLine("Que ótimo! Você é maior de idade");
            } else
            {
                Console.WriteLine("Infelizmente você não possui maioridade.");
            }
        }

    }
}

