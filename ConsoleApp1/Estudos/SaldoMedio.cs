namespace ConsoleApp1.Estudos
{
    public class SaldoMedio
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o seu saldo médio.");
            var saldoMedio = Convert.ToDecimal(Console.ReadLine());
            var percentual = calcularPercentualCredito(saldoMedio);
            var credito = (percentual * saldoMedio);

            Console.WriteLine($"Seu saldo médio é de {saldoMedio} e o seu crédito foi de {credito}.");
        }

        private static decimal calcularPercentualCredito(decimal saldoMedio)
        {
            decimal percentual = 0;

            if (saldoMedio >= 201 && saldoMedio < 401)
                percentual = Convert.ToDecimal((20m/100));

            if (saldoMedio >= 401 && saldoMedio < 601)
                percentual = Convert.ToDecimal((30m/100));

            if (saldoMedio >= 601)
                percentual = Convert.ToDecimal((40m/100));

            return percentual;
        }
    }
}