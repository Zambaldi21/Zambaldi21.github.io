using ConsoleApp1.Utils;


namespace ConsoleApp1.Estudos
{
    public class Fruteira
    {
        public static void Processar()
        {
            var dadosIo = new DadosIo();
            var calculoFruta = new CalculoFruta();

            calculoFruta.Morango = dadosIo.SolicitarValorDecimalAoUsuario("Digite quantos kilos o cliente comprou de morango", 0);
            calculoFruta.Maca = dadosIo.SolicitarValorDecimalAoUsuario("Digite quantos kilos o cliente comprou de maçã", 0);

            calculoFruta.ValorTotal = calculoFruta.CalcularValorFruta();

            var mensagem = $" O morango custou R$ {calculoFruta.ValorMorango} reais e a maçã custou R$ {calculoFruta.ValorMaca} reais";
            var desconto = "e teve desconto de 10% em cima do valor total da compra";

            if (calculoFruta.ValorTotal > 25)
                Console.WriteLine($"O valor total é de R$ {calculoFruta.ValorTotal} reais {desconto}." + mensagem);

            else
                Console.WriteLine($"O valor total é de R$ {calculoFruta.ValorTotal} reais." + mensagem);

        }
    }
    public class CalculoFruta
    {
        public decimal Morango { get; set; }
        public decimal Maca { get; set; }
        public decimal ValorMorango { get; set; }
        public decimal ValorMaca { get; set; }
        public decimal ValorTotal { get; set; }

        public decimal CalcularValorFruta()
        {
            ValorMorango = 0;

            if (Morango > 5 && Morango <= 8)
                ValorMorango = Math.Round(Morango * 2.20m, 2);

            else if ((Morango > 8) || (ValorMorango > 25))
            {
                ValorMorango = Morango * 2.20m;
                ValorMorango = Math.Round(ValorMorango - (ValorMorango * (0.1m)), 2);
            }

            else
                ValorMorango = Math.Round(Morango * 2.50m, 2);

            ValorMaca = 0;


            if (Maca > 5 && Maca <= 8)
                ValorMaca = Math.Round(Maca * 1.50m, 2);

            else if ((Maca > 8) || (ValorMaca > 25))
            {
                ValorMaca = Maca * 1.50m;
                ValorMaca = Math.Round(ValorMaca - (ValorMaca * (0.1m)), 2);
            }

            else
                ValorMaca = Math.Round(Maca * 1.80m, 2);

            ValorTotal = ValorMaca + ValorMorango;

            if (ValorTotal > 25)
            {
                var percentual = (10m / 100m) * ValorTotal;
                ValorTotal = Math.Round(ValorTotal - percentual, 2);
            }

            return ValorTotal;
        }
    }
}