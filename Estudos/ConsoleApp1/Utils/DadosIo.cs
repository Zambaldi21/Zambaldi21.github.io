namespace ConsoleApp1.Utils
{
    public class DadosIo
    {
        public decimal ObterValor(string descricao, decimal minValue = decimal.MinValue, decimal maxValue = decimal.MaxValue)
        {
            Console.Write($"{descricao}: ");
            var valor = ObterValor();
            while (valor < minValue || valor > maxValue)
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
}