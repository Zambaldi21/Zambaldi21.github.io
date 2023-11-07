namespace ConsoleApp1.Estudos
{
    public class Aposentadoria
    {
        public static void Processar()
        {
            var codigoFuncionario = ObterDado("Digite o código do funcionário.");
            var nascimentoFuncionario = ObterDado("Digite o ano de nascimento do funcionário.");
            var admissaoFuncionario = ObterDado("Digite o ano da admissao do funcionário.");

            var resultadoParaAposentadoria = Calcular(nascimentoFuncionario, admissaoFuncionario);
                
            if (resultadoParaAposentadoria.PodeRequererAposentadoria)
                Console.WriteLine($"O funcionário está trabalhando conosco a {resultadoParaAposentadoria.AnosTrabalhado} anos " +
                    $"e tem {resultadoParaAposentadoria.AnosFuncionario} anos. Pode requerer aposentadoria");
            else
                Console.WriteLine("O funcionário não pode requerer aposentadoria.");
        }

        private static ResultadoParaAposentadoria Calcular(int nascimentoFuncionario, int admissaoFuncionario)
        {
            var anoAtual = 2023;
            var idadeFuncionario = anoAtual - nascimentoFuncionario;
            var anosTrabalhado = anoAtual - admissaoFuncionario;

            var podeRequererAposentadoria =
                (idadeFuncionario >= 65)
                || (anosTrabalhado >= 30)
                || ((anosTrabalhado >= 25) && (idadeFuncionario >= 60));

            return new ResultadoParaAposentadoria { AnosFuncionario = idadeFuncionario, AnosTrabalhado = anosTrabalhado, PodeRequererAposentadoria = podeRequererAposentadoria };
        }

        private static int ObterDado(string descricao)
        {
            Console.WriteLine(descricao);
            var opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
    }

    public class ResultadoParaAposentadoria
    {
        public int AnosFuncionario { get; set; }
        public int AnosTrabalhado { get; set; }
        public bool PodeRequererAposentadoria { get; set; }
    }

}