using System.ComponentModel;

namespace ConsoleApp1.Estudos
{
    public class NumerosEleitores
    {
        public static void Processar()
        {
            Console.Write("Digite a quantidade de eleitores: ");
            var eleitorTotal = Convert.ToDecimal(Console.ReadLine());
            var eleitorBranco = ObterEleitores("eleitores que votaram em branco", eleitorTotal);
            var eleitorNulo = ObterEleitores("eleitores que votaram em nulo", eleitorTotal - eleitorBranco);
            var calculaBranco = CalcularDados(eleitorTotal, eleitorBranco);
            var calculaNulo = CalcularDados(eleitorTotal, eleitorNulo);
            var calculaValido = ((calculaBranco + calculaNulo) - 100) * -1;
            Console.WriteLine();
            Console.WriteLine($" O número total de eleitores foi de {eleitorTotal}, " +
                $"os que votaram em branco se concetram em {calculaBranco}%, " +
                $"os que votaram em nulo são de {calculaNulo}% " +
                $"e os votos válidos foram de {calculaValido}%.");

        }

        private static decimal ObterEleitores(string descricao, decimal eleitorTotal)
        {
            Console.Write($"Digite a quantidade de {descricao}: ");
            var eleitor = Convert.ToInt32(Console.ReadLine());
            while ((eleitor > eleitorTotal) || (eleitor < 0))
            {
                Console.WriteLine("O número digitado não pode ser maior e nem menor do que os números totais de eleitores. Por favor, digite novamente.");
                eleitor = Convert.ToInt32(Console.ReadLine());
            }


            return eleitor;
        }

        private static decimal CalcularDados(decimal numeroEleitorTotal, decimal numeroEleitor)
        {
            return Math.Round((numeroEleitor / numeroEleitorTotal) * 100m, 2);
        }
    }
}