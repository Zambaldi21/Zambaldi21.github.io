using System.Globalization;

namespace ConsoleApp1
{
    public class Testes
    {
        public static void Processar()
        {
            double x;
            x = 2.3456;
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}