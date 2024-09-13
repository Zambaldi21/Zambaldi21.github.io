using System.Globalization;

namespace ConsoleApp1.Utils
{
    public class DadosIo
    {
        private static readonly IFormatProvider ptBR = new CultureInfo("pt-BR");

        public DateTime SolicitarDataComHoraAoUsuario(string descricao, DateTime? minValue = null, DateTime? maxValue = null)
        {
            const string format = "dd/MM HH:mm";
            var min = minValue ?? DateTime.MinValue;
            var max = maxValue ?? DateTime.MaxValue;

            Console.Write($"{descricao}. (Formato '{format}'): ");
            var valor = Console.ReadLine();
            if (DateTime.TryParseExact(valor, format, ptBR, DateTimeStyles.AssumeLocal, out var dataHora))
            {
                while (dataHora < min || dataHora > max)
                {
                    if (dataHora < min)
                        Console.Write($"O valor mínimo é {min}. {descricao}: ");
                    else if (dataHora > max)
                        Console.Write($"O valor máximo é {max}. {descricao}: ");

                    dataHora = SolicitarDataComHoraAoUsuario(descricao, minValue, maxValue);
                }
            }

            return dataHora;
        }


        public long SolicitarValorInteiroAoUsuario(string descricao, long? minValue = null, long? maxValue = null)
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