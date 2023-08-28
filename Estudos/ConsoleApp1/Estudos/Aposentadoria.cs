namespace ConsoleApp1.Estudos
{
    public class Aposentadoria
    {
        public static void Processar()
        {
            var codigoFuncionario = ObterDado("Digite o código do funcionário.");
            var nascimentoFuncionario = ObterDado("Digite o ano de nascimento do funcionário.");
            var admissaoFuncionario = ObterDado("Digite o ano da admissao do funcionário.");

            var anoAtual = 2023;
            var anosFuncionario = anoAtual - nascimentoFuncionario;
            var anosTrabalhado = anoAtual - admissaoFuncionario;

            if (anosFuncionario >= 65)
            {
                Console.WriteLine($"O funcionário está trabalhando conosco a {anosTrabalhado} anos e tem {anosFuncionario} anos. Requer aposentadoria");
            }
            else if (anosTrabalhado >= 30)
            {
                Console.WriteLine($"O funcionário está trabalhando conosco a {anosTrabalhado} anos e tem {anosFuncionario} anos. Requer aposentadoria");
            }
            else if ((anosTrabalhado >= 25) && (anosFuncionario >= 60))
            {
                Console.WriteLine($"O funcionário está trabalhando conosco a {anosTrabalhado} anos e tem {anosFuncionario} anos. Requer aposentadoria");
            }
            else
            {
                Console.WriteLine("O funcionário não requer aposentadoria.");
            }

        }

        private static string VerificaAposentadora(int dado)
        {
            if (dado >= 65)
            {
                Console.WriteLine();
            }
            return "juan";
        }


        private static int ObterDado(string descricao)
        {
            Console.WriteLine(descricao);
            var opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
    }
}