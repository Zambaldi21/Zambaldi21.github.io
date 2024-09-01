
namespace ConsoleApp1.Estudos
{
    public class BrincandoComArrays
    {
        public static void Processar()
        {
            int[] a = new int[6];

            a[0] = 1;
            a[1] = 0;
            a[2] = 5;
            a[3] = -2;
            a[4] = 100;
            a[5] = 7;

            var resultado = a[0] + a[1] + a[5];

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);
            Console.WriteLine(a[5]);
        }
    }
}
