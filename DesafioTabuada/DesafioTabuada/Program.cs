namespace DesafioTabuada;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Seja bem-vindo a tabuada interativa! =====");
       
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Digite um número para a tabuada do 1 ao 10: ");
            int tabuada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tabuada do " + tabuada + ": ");

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(tabuada * i);
                i++;
            }
            Console.WriteLine("Deseja ver outra tabuada? (S/N): ");
            string resposta = Console.ReadLine();

            if ( resposta == "N")
            {
                continuar = false;
            }
        }
        Console.WriteLine("Obrigada por usar a tabuada interativa!");
    }
}
