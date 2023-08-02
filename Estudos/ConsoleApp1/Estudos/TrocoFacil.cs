using System.Diagnostics;

namespace ConsoleApp1.Estudos
{
    public class TrocoFacil
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o valor total da compra.");
            var totalDaCompra = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor recebido do cliente.");
            var totalRecebido = Convert.ToDecimal(Console.ReadLine());

            totalRecebido = Convert.ToDecimal(cobrarCliente(totalDaCompra, totalRecebido));

            var valorTroco = (totalRecebido - totalDaCompra);

            if (valorTroco > 0)
            {
                var valorTrocoOriginal = valorTroco;
                valorTroco = entregarTroco(valorTroco, 100);
                valorTroco = entregarTroco(valorTroco, 50);
                valorTroco = entregarTroco(valorTroco, 20);
                valorTroco = entregarTroco(valorTroco, 10);
                valorTroco = entregarTroco(valorTroco, 5);
                valorTroco = entregarTroco(valorTroco, 1);
                valorTroco = entregarTroco(valorTroco, 0.50M);
                valorTroco = entregarTroco(valorTroco, 0.25M);
                valorTroco = entregarTroco(valorTroco, 0.10M);
                valorTroco = entregarTroco(valorTroco, 0.05M);
                valorTroco = entregarTroco(valorTroco, 0.01M);

                Console.WriteLine($"Seu troco é de {valorTrocoOriginal}. Obrigado pela preferência, volte sempre! ");

            }
            else
            {
                Console.WriteLine("Obrigado pela preferência. Volte sempre!");
            }
        }

        private static decimal entregarTroco(decimal valorTroco, decimal cedula)
        {
            while (valorTroco >= cedula)
            {
                Console.WriteLine($"Pegue uma cédula de {cedula} e entregue para o cliente.");
                valorTroco = valorTroco - cedula;
            }
            return valorTroco;

        }

        private static string cobrarCliente(decimal valorTotalCompra, decimal valorRecebido)
        {
            while (valorRecebido < valorTotalCompra)
            {
                Console.WriteLine($"Por favor, me entregue uma quantia que seja maior ou igual a {valorTotalCompra} reais.");
                valorRecebido = Convert.ToDecimal(Console.ReadLine());
            }
            return Convert.ToString(valorRecebido);
        }
    }
}
