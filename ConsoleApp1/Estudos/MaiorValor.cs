using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class MaiorValor
    {
        public static void Processar()
        {
            // Instância objetos
            var juanIo = new DadosIo();
            var valores = new Valores();

            // Solicita entradas
            valores.ValorA = juanIo.SolicitarValorInteiroAoUsuario("Digite o valor de A: ");
            valores.ValorB = juanIo.SolicitarValorDecimalAoUsuario("Digite o valor de B: ");
            valores.ValorC = juanIo.SolicitarValorDecimalAoUsuario("Digite o valor de C: ");

            // Verifica maior valor
            valores.MaiorValor = valores.VerificaMaiorValor();

            // Mostra resultado
            Console.WriteLine();
            Console.WriteLine($"O maior valor é {valores.MaiorValor}.");
        }
    }
    public class Valores
    {
        public decimal ValorA { get; set; }
        public decimal ValorB { get; set; }
        public decimal ValorC { get; set; }
        public decimal MaiorValor { get; set; }

        public decimal VerificaMaiorValor()
        {
            MaiorValor = ValorA;

            if (ValorB > MaiorValor)
                MaiorValor = ValorB;

            if (ValorC > MaiorValor)
                MaiorValor = ValorC;

            return MaiorValor;
        }
    }
}