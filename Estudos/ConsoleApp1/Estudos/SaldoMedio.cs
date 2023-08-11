namespace ConsoleApp1.Estudos
{
    public class SaldoMedio
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o seu saldo médio.");
            var saldoMedio = Convert.ToDecimal(Console.ReadLine());
            var credito = calculaCredito(saldoMedio);
        }

        private static decimal calculaCredito(decimal saldoMedio)
        {
            if (saldoMedio >= 201 && saldoMedio < 401)
            {
                var percentual = Convert.ToDecimal((20m/100));
                var credito = (percentual * saldoMedio);
                Console.WriteLine($"Seu saldo médio é de {saldoMedio} e o seu crédito foi de {credito}.");

            }

            if (saldoMedio >= 401 && saldoMedio < 601)
            {
                var percentual = Convert.ToDecimal((30m/100));
                var credito = (percentual * saldoMedio);
                Console.WriteLine($"Seu saldo médio é de {saldoMedio} e o seu crédito foi de {credito}.");

            }

            if (saldoMedio >= 601)
            {
                var percentual = Convert.ToDecimal((40m/100));
                var credito = (percentual * saldoMedio);
                Console.WriteLine($"Seu saldo médio é de {saldoMedio} e o seu crédito foi de {credito}.");

            }

            Console.WriteLine($"Seu saldo médio é de {saldoMedio} e você não tem direito a crédito.");

            return saldoMedio;
        }
    }
}