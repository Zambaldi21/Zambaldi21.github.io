using ConsoleApp1.Utils;

public class Fatorial
{
    public decimal Fatorial1(decimal x)
    {
        var auxiliar = x;

        while (auxiliar <= x)
        {
            var auxiliar1 = 1;
            x *= auxiliar1;
        }
        return x;
    }

    public static void Processar()
    {
        var fatorial = new Fatorial();
        var dadosIo = new DadosIo();

        var numero = dadosIo.SolicitarValorDecimalAoUsuario("Digite um valor qualquer: ");
        var resultado = fatorial.Fatorial1(numero);

        Console.WriteLine(resultado);
    }
}