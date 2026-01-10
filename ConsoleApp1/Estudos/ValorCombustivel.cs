namespace ConsoleApp1.Estudos
{
    public class ValorCombustivel
    {
        public static void Processar()
        {
            var opcao = ObterDados();
            var valor = CalculaValor(opcao);
            if (valor > 1)
            {
                Console.WriteLine($"O valor a ser pago é R${valor} reais");
            }

        }

        private static decimal CalculaValor(string opcao)
        {
            decimal litro = 0;
            decimal valor = 0;
            switch (opcao)
            {
                case "A":
                    Console.WriteLine("Digite quantos litros de abastecimento.");
                    litro = Convert.ToDecimal(Console.ReadLine());
                    if (Convert.ToDecimal(litro) > 20)
                    {
                        var percentual = litro * (5M/100M);
                        valor = Math.Round(2.90m * litro - percentual, 2);
                    }
                    else
                    {
                        var percentual = litro * (3M/100M);
                        valor = Math.Round(2.90m * litro - percentual, 2);
                    }
                    break;
                case "G":
                    Console.WriteLine("Digite quantos litros de abastecimento.");
                    litro = Convert.ToDecimal(Console.ReadLine());
                    if (Convert.ToDecimal(litro) > 20)
                    {
                        var percentual = litro * (6M/100M);
                        valor = Math.Round(3.30m * litro  - percentual, 2);
                    }
                    else
                    {
                        var percentual = litro * (4M/100M);
                        valor = Math.Round(3.30m * litro - percentual, 2);
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            return valor;
        }


        private static string ObterDados()
        {
            Console.WriteLine("Digite G para gasolina");
            Console.WriteLine("Digite A para álcool");
            var opcao = Console.ReadLine();
            return opcao;
        }
    }
}