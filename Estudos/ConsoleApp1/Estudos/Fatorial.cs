public class Fatorial
{
    public int Fatorial1(int x)
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
        var resultado = fatorial.Fatorial1(5);
        Console.WriteLine(resultado);
    }
}