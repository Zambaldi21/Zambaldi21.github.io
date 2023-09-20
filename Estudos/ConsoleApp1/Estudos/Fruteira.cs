using ConsoleApp1.Utils;
using System.Globalization;

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

            calculoFruta.ValorMorango = calculoFruta.CalcularValorMorango();
            calculoFruta.ValorMaca = calculoFruta.CalcularValorMaca();

            var valorTotal = calculoFruta.ValorMorango + calculoFruta.ValorMaca;
            calculoFruta.ValorTotal = calculoFruta.AcimaDe25();

            if (valorTotal > 25)
            {
                Console.WriteLine("O valor total é de R$ {0} reais e teve desconto de 10% em cima do valor total da compra. O morango custou R$ {1} reais e a maçã custou R$ {2} reais ", calculoFruta.ValorTotal, calculoFruta.ValorMorango, calculoFruta.ValorMaca);
            }
            else
            {
                Console.WriteLine("O valor total é de R$ {0} reais. O morango custou R$ {1} reais e a maçã custou R$ {2} reais ", calculoFruta.ValorTotal, calculoFruta.ValorMorango, calculoFruta.ValorMaca);
            }
        }
    }
    public class CalculoFruta
    {
        public decimal Morango { get; set; }
        public decimal Maca { get; set; }
        public decimal ValorMorango { get; set; }
        public decimal ValorMaca { get; set; }
        public decimal ValorTotal { get; set; }

        public decimal CalcularValorMorango()
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

            return ValorMorango;
        }

        public decimal CalcularValorMaca()
        {
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

            return ValorMaca;
        }

        public decimal AcimaDe25()
        {
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