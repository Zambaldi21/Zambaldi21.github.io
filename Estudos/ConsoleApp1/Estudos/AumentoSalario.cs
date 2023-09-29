using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class AumentoSalario
    {
        public static void Processar()
        {
            // Declara variáveis para melhor visualização
            var mensagemNome = "Digite seu nome: ";
            var mensagem1 = "Digite o código segundo o seu cargo.";
            var mensagem2 = "Gerente - 101 ";
            var mensagem3 = "Engenheiro - 102";
            var mensagem4 = "Técnico - 103";
            var mensagem5 = "Outro - 104";
            var mensagemSalario = "Digite o seu salário: ";

            // Instância objetos
            var dadosIo = new DadosIo();
            var Salario = new CalculaAumento();

            // Solicita dados do usuário
            Salario.Nome = dadosIo.SolicitarNomeAoUsuario(mensagemNome);
            Console.WriteLine(mensagem1);
            Console.WriteLine(mensagem2);
            Console.WriteLine(mensagem3);
            Console.WriteLine(mensagem4);
            Console.WriteLine(mensagem5);
            Salario.Cargo = Salario.obterCargo();
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
        public int Cargo { get; set; }
        public decimal Salario { get; set; }
        public int obterCargo()
        {
            Cargo = Convert.ToInt32(Console.ReadLine());
            return Cargo;
        }
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