using ConsoleApp1.Utils;

public class Testes
{
    public static void Processar()
    {
        var dadosIo = new DadosIo();

        //Inputs
        var valorA = Convert.ToDouble(dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor A: "));
        var valorB = Convert.ToDouble(dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor B: "));
        var valorC = Convert.ToDouble(dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor C: "));

        //process
        var delta = Math.Pow(valorB, 2) - (4 * valorA * valorC);
        var resultadoPositivo = (-valorB + delta) / (2 * valorA);
        var resultadoNegativo = (+valorB + delta) / (2 * valorA);

        //Output
        Console.WriteLine($"Resultado positivo: {resultadoPositivo}");
        Console.WriteLine($"Resultado negativo: {resultadoNegativo}");
    }
}

/*
public static int Somar(int n1, int n2)
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
}
*/