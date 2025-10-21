namespace DesafioDesconto;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Bem-vindo ao sistema de desconto por faixa de valor =====");
        Console.WriteLine("Digite o valor da sua compra:");

        float valor = float.Parse(Console.ReadLine());
     
        if ( valor <= 100)
        {
            Console.WriteLine("O seu desconto será de 10%, sendo assim, o valor é " + (valor - (valor / 10)));
        } else if (valor >= 101 && valor <= 500)
        {
            Console.WriteLine("O seu decsonto é de 15%, sendo assim, o valor é " + (valor - (valor * 0.15)));
        } else
        {
            Console.WriteLine("O seu desconto é de 20%, sendo assim, o valor é " + (valor - (valor * 0.2)));
        }
    }
}