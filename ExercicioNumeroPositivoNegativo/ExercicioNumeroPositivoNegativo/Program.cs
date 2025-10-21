using System.ComponentModel.Design;

namespace ExercicioNumeroPositivoNegativo
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("========== Verificador de número ==========");
            Console.WriteLine("Digite um número: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("O número " + number + " é positivo.");

            } else if (number < 0) 
            {
                Console.WriteLine("O número " + number + " é negativo."); 

            } else
            {
                Console.WriteLine("O número é zero.");
            }
        }
    }
}
