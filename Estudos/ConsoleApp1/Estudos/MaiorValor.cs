namespace ConsoleApp1.Estudos
{
    public class MaiorValor
    {
        public static void Processar()
        {
            var juanIo = new DadosIo();
            var valores = new Valores();

            valores.ValorA = juanIo.ObterValor("Digite o valor de A", 0, 10);
            valores.ValorB = juanIo.ObterValor("Digite o valor de B");
            valores.ValorC = juanIo.ObterValor("Digite o valor de C");
            valores.MaiorValor = valores.VerificaMaiorValor(valores.ValorA, valores.ValorB, valores.ValorC);

            Console.WriteLine();
            Console.WriteLine($"O maior valor é {valores.MaiorValor}.");
        }
    }

    public class DadosIo
    {
        public decimal ObterValor(string descricao, decimal minValue = decimal.MinValue, decimal maxValue = decimal.MaxValue)
        {
            Console.Write($"{descricao}: ");
            var valor = ObterValor();
            while ((valor < minValue) || (valor > maxValue))
            {
                if (valor < minValue)
                    Console.Write($"O valor mínimo é {minValue}. {descricao}: ");
                else if (valor > maxValue)
                    Console.Write($"O valor máximo é {maxValue}. {descricao}: ");

                valor = ObterValor();
            }
            return valor;
        }
        
        public decimal ObterValor()
        {
            try
            {
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.Write("Valor Inválido. Digite novamente: ");
                return ObterValor();
            }
        }
    }



    public class Valores
    {
        public decimal ValorA { get; set; }
        public decimal ValorB { get; set; }
        public decimal ValorC { get; set; }
        public decimal MaiorValor { get; set; }


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