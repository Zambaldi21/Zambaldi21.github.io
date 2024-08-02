public class Testes
{
    public static void Processar()
    {
        //Inputs
        Console.WriteLine("Descubra o maior valor.");
        var valorA = Mensagem("Escreva o valor de A:");
        var valorB = Mensagem("Escreva o valor de B:");
        var valorC = Mensagem("Escreva o valor de C:");

        //Process
        var maiorValor = Calcular(valorA, valorB, valorC);

        //Outputs
        Console.WriteLine($"O maior valor é {maiorValor}" + $" e a soma total dos valores é {valorA + valorB + valorC}.");
    }

    private static decimal Mensagem(string mensagem)
    {
        Console.Write($"{mensagem}");
        var valor = Convert.ToDecimal(Console.ReadLine());
        return valor;
    }

    private static decimal Calcular(decimal valorA, decimal valorB, decimal valorC)
    {
        decimal maiorValor = valorA;

        if (valorB > maiorValor)
        {
            maiorValor = valorB;
        }

        if (valorC > maiorValor)
        {
            maiorValor = valorC;
        }

        return maiorValor;
    }

    /*public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }*/
}
