namespace ConsoleApp1
{
    public class Testes
    {
        public static void Processar()
        {
            Console.WriteLine("Vamos analisar o maior valor entre 3 números!");

            var valorA = obterNumeros("Digite o valor de A: ");
            var valorB = obterNumeros("Digite o valor de B: ");
            var valorC = obterNumeros("Digite o valor de C: ");

            var maiorValor = valorA;

            if (maiorValor < valorB)
            {
                maiorValor = valorB;
            }
            if (maiorValor < valorC)
            {
                maiorValor = valorC;
            }

            Console.WriteLine($"O maior valor é {maiorValor}.");
        }

        private static decimal obterNumeros(string descricao)
        {
            Console.Write(descricao);
            var valor = Convert.ToDecimal(Console.ReadLine());
            return valor;
        }
    }
}