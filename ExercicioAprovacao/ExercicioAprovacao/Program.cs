using System.Globalization; // Necessário para utilizar o CultureInfo

namespace ExercicioAprovacao
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("======== Verificação de aprovação na média final ========");
            Console.WriteLine("Qual foi a sua média final?");
            Console.WriteLine("Digite a média aqui: ");

            string input = Console.ReadLine()!; // Definindo que a variável precisa ser inserida e usando "!" para definir que nunca será nula
            float media = float.Parse(input, CultureInfo.InvariantCulture); // Definindo que o input é a média e o CultureInfo vai deixar a pessoa colocar ponto no lugar de vírgula

            if (media >= 6)
            {
                Console.WriteLine("Parabéns!!! Você foi aprovado");
            }
            else if (media >= 4 && media < 6)
            {
                Console.WriteLine("Você precisa realizar a recuperação.");
            }
            else
            {
                Console.WriteLine("Você foi reprovado.");
            }
        }
    }
}
