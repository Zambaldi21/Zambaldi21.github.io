using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class CalculaValorD
    {
        public static void Processar()
        {
            // Inputs
            var dadosIo = new DadosIo();
            var calculoValor = new CalculoValor();
            calculoValor.ValorA = dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor de A: ");
            calculoValor.ValorB = dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor de B: ");
            calculoValor.ValorC = dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor de C: ");

            // Process
            calculoValor.Resultado = calculoValor.CalculaD();
            

            // Outputs
            Console.WriteLine($"O valor de D é {calculoValor.Resultado}.");
        }
    }
    public class CalculoValor
    {
        public decimal ValorA { get; set; }
        public decimal ValorB { get; set; }
        public decimal ValorC { get; set; }
        public decimal Resultado { get; set; }
        public decimal CalculaD()
        {
            var ValorR = Convert.ToDouble(ValorA + ValorB);
            var dobroR = Math.Pow(ValorR, 2);
            var valorS = Convert.ToDouble(ValorB + ValorC);
            var dobroS = Math.Pow(valorS, 2);
            Resultado = Convert.ToDecimal((dobroR + dobroS) / 2);

            return Convert.ToDecimal(Resultado);
        }
    }
}