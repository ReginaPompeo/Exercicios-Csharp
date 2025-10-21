namespace DesafioClassificacaoDeTriangulo;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Bem-vindo ao classificador de triângulos =====");
        Console.WriteLine("Digite o tamanho do primeiro lado: ");

        int lado1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o tamanho do segundo lado: ");

        int lado2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o tamanho do terceiro lado: ");

        int lado3 = Convert.ToInt32(Console.ReadLine());

        if ((lado1 == lado2) && (lado1 == lado3))
        {
            Console.WriteLine("Esse triângulo é Equilátero!");
        } else if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
        {
            Console.WriteLine("Esse triângulo é Isósceles!");
        } else
        {
            Console.WriteLine("Esse triângulo é Escaleno!");
        }

    }
}