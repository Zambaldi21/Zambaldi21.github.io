using System.ComponentModel;

namespace ConsoleApp1.Estudos
{
    public class NumerosEleitores
    {
        public static void Processar()
        {

            var x = 10;
            while (x> 0)
            {
                x -=2;
                Console.WriteLine(x);
            }

            var calculoEleitores = new CalculoEleitores();

            calculoEleitores.TotalEleitores = ObterEleitores("Digite a quantidade total de eleitores: ", int.MaxValue);
            calculoEleitores.VotosBrancos = ObterEleitores("Digite a quantidade de eleitores que votaram em branco: ", calculoEleitores.TotalEleitores);
            calculoEleitores.VotosNulos = ObterEleitores("Digite a quantidade de eleitores que votaram em nulo: ", calculoEleitores.TotalEleitores - calculoEleitores.VotosBrancos);

            calculoEleitores.CalculaPorcentagem();
            //var calculaNulo = CalcularDados(eleitorTotal, eleitorNulo);
            //var calculaValido = ((calculaBranco + calculaNulo) - 100) * -1;
            //Console.WriteLine();
            Console.WriteLine($"O número total de eleitores foi de {calculoEleitores.TotalEleitores}, " +
                $"os que votaram em branco se concetram em {calculoEleitores.PorcentagemBranco}%");
            //, " +
            //    $"os que votaram em nulo são de {calculaNulo}% " +
            //    $"e os votos válidos foram de {calculaValido}%.");

        }

        private static int ObterEleitores(string descricao, int totalEleitores)
        {
            Console.Write(descricao);
            var votos = Convert.ToInt32(Console.ReadLine());
            while ((votos > totalEleitores) || (votos < 0))
            {
                Console.WriteLine("O número digitado não pode ser maior e nem menor do que os números totais de eleitores. Por favor, digite novamente.");
                votos = Convert.ToInt32(Console.ReadLine());
            }
            return votos;
        }
    }

    public class CalculoEleitores
    {
        public int TotalEleitores;
        public int VotosBrancos;
        public int VotosNulos;

        public decimal VotosValidos { get; private set; }
        public decimal PorcentagemValidos { get; private set; }
        public decimal PorcentagemBranco { get; private set; }
        public decimal PorcentagemNulo { get; private set; }

        public void CalculaPorcentagem()
        {
            VotosValidos = TotalEleitores - VotosBrancos - VotosNulos;
            PorcentagemValidos = CalculaPorcentagem(TotalEleitores, VotosValidos);
            PorcentagemBranco = CalculaPorcentagem(TotalEleitores, VotosBrancos);
            PorcentagemNulo = CalculaPorcentagem(TotalEleitores, VotosNulos);
        }

        private decimal CalculaPorcentagem(decimal numeroEleitorTotal, decimal tipoEleitor)
        {
            return Math.Round(100m * tipoEleitor / numeroEleitorTotal, 2);
        }
    }

}