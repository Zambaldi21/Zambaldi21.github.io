namespace ConsoleApp1.Estudos
{
    public class MaiorValor
    {
        public static void Processar()
        {
            var valores = new Valores();

            valores.ValorA = valores.ObterValores("Digite o valor de A");
            valores.ValorB = valores.ObterValores("Digite o valor de B");
            valores.ValorC = valores.ObterValores("Digite o valor de C");
            valores.MaiorValor = valores.VerificaMaiorValor(valores.ValorA, valores.ValorB, valores.ValorC);

            Console.WriteLine();
            Console.WriteLine($"O maior valor é {valores.MaiorValor}.");
        }
    }

    public class Valores
    {
        public decimal ValorA { get; set; }
        public decimal ValorB { get; set; }
        public decimal ValorC { get; set; }
        public decimal Valor { get; set; }
        public decimal MaiorValor { get; set; }

        public decimal ObterValores(string descricao)
        {
            Console.WriteLine(descricao);
            Valor = Convert.ToDecimal(Console.ReadLine());
            return Valor;
        }

        public decimal VerificaMaiorValor(decimal ValorA, decimal ValorB, decimal ValorC)
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