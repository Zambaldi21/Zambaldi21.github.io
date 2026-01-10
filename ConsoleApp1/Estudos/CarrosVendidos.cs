using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class CarrosVendidos
    {
        public static void Processar()
        {
            // Inputs
            var dadosIo = new DadosIo();
            var vendaCarro = new VendaCarro();
            vendaCarro.SalarioFixo = dadosIo.SolicitarValorDecimalAoUsuario("Digite o salário fixo: ", 0);
            vendaCarro.TotalDeCarrosVendidos = Convert.ToInt32(dadosIo.SolicitarValorInteiroAoUsuario("Digite quantos carros foram vendidos: ", 0));
            vendaCarro.ValorTotalVendas = dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor total das suas vendas: ", 0);
            vendaCarro.ValorComissaoFixaPorCarroVendido = dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor fixo da comissão: ", 0);

            //Process
            vendaCarro.NovoSalario = vendaCarro.CalculoSalario();

            //Output
            Console.WriteLine($"O salário desse mês é de {vendaCarro.NovoSalario}");
        }
    }
    public class VendaCarro
    {
        public decimal SalarioFixo { get; set; }
        public int TotalDeCarrosVendidos { get; set; }
        public decimal ValorTotalVendas { get; set; }
        public decimal ValorComissaoFixaPorCarroVendido { get; set; }
        public decimal NovoSalario { get; set; }

        public decimal CalculoSalario() => CalculaSalario();

        private decimal CalculaSalario() => SalarioFixo + (ValorTotalVendas / 0.5m) + (ValorComissaoFixaPorCarroVendido * TotalDeCarrosVendidos);
    }
}