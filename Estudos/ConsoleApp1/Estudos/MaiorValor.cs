namespace ConsoleApp1.Estudos
{
    public class MaiorValor
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o valor de A.");
            var valorDeA = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor de B.");
            var valorDeB = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor de C.");
            var valorDeC = Convert.ToDecimal(Console.ReadLine());
            var maiorNumero = valorDeA;

            if (valorDeB > maiorNumero)
            {
                maiorNumero = valorDeB;
            }
            if (valorDeC > maiorNumero)
            {
                maiorNumero = valorDeC;
            }
            Console.WriteLine($"O maior valor é {maiorNumero}.");
        }
    }
}