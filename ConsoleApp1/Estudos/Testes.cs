namespace ConsoleApp1
{
    public class Testes
    {
        public static void Processar()
        {
            Console.Write("Digite um valor A: ");
            var valorA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um valor B: ");
            var valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(valorA + valorB);

        }
    }
}