namespace ConsoleApp1.Utils
{
    public class DadosIo
    {
        public int SolicitarValorInteiroAoUsuario(string descricao, long? minValue = null, long? maxValue = null)
        {
            var numeroDecimal = SolicitarValorDecimalAoUsuario(descricao, minValue, maxValue);

            var numeroInteiro = Convert.ToInt32(numeroDecimal);
            if (numeroDecimal == numeroInteiro)
                return numeroInteiro;

            else
            {
                Console.Write($"O Número digitado não é inteiro. ");
                return SolicitarValorInteiroAoUsuario(descricao, minValue, maxValue);
            }
        }

        public decimal SolicitarValorDecimalAoUsuario(string descricao, decimal? minValue = null, decimal? maxValue = null)
        {
            var min = minValue ?? decimal.MinValue;
            var max = maxValue ?? decimal.MaxValue;

            Console.Write(descricao);
            var valor = ObterValor();
            while (valor < min || valor > max)
            {
                if (valor < min)
                    Console.Write($"O valor mínimo é {min}. {descricao}: ");
                else if (valor > max)
                    Console.Write($"O valor máximo é {max}. {descricao}: ");

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

        public string SolicitarStringAoUsuario(string descricao)
        {
            Console.Write(descricao);
            var texto = Console.ReadLine();
            return texto;
        }

        public void saida(string descricao)
        {
            Console.WriteLine(descricao);
        }
    }
}