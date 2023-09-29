using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class AumentoSalario
    {
        // Declara variáveis para melhor visualização
        private const string mensagemNome = "Digite seu nome: ";
        private const string mensagemSalario = "Digite o seu salário: ";
        private const string mensagem = @"Digite o código segundo o seu cargo.
        Gerente - 101
        Engenheiro - 102
        Técnico - 103
        Outro - 104: ";

        public static void Processar()
        {
            // Instancia objetos
            var dadosIo = new DadosIo();
            var Salario = new CalculaAumento();

            // Solicita dados do usuário
            Salario.Nome = dadosIo.SolicitarNomeAoUsuario(mensagemNome);
            Salario.Cargo = dadosIo.SolicitarValorInteiroAoUsuario(mensagem, 101, 104);
            Salario.Salario = dadosIo.SolicitarValorDecimalAoUsuario(mensagemSalario);

            // Calcula a diferença de salário e o novo salário
            var aumentoSalario = Salario.percentualAumento();
            var novoSalario = Salario.Salario + aumentoSalario;

            // Mostra resultado
            Console.WriteLine($"{Salario.Nome}, o seu salário antigo é de {Salario.Salario}, " +
                $"o seu novo salário é {novoSalario} e a diferença é de {aumentoSalario}.");
        }
    }
    public class CalculaAumento
    {
        public string Nome { get; set; }
        public long Cargo { get; set; }
        public decimal Salario { get; set; }

        public decimal percentualAumento()
        {
            decimal percentual;

            switch (Cargo)
            {
                case 101:
                    percentual = 0.1m;
                    break;
                case 102:
                    percentual = 0.2m;
                    break;
                case 103:
                    percentual = 0.3m;
                    break;
                case 104:
                    percentual = 0.4m;
                    break;
                default:
                    percentual = 0;
                    break;
            }
            return percentual * Salario;
        }
    }
}