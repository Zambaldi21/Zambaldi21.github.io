using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos.Media
{
    public class Medias
    {
        public static void Processar()
        {
            var dadosIo = new DadosIo();

            var tipoDeEscola = TipoDeEscola();

            var parametroEscola = new ParametrosEscola { NomeEscola = "Generica", MediaAprovacao = 7 };
            if (tipoDeEscola == 1)
                parametroEscola = new ParametrosEscola { NomeEscola = "Molezinha da Estrela", MediaAprovacao = 3 };
            if (tipoDeEscola == 2)
                parametroEscola = new ParametrosEscola { NomeEscola = "Nem lá nem cá", MediaAprovacao = 5 };
            if (tipoDeEscola == 3)
                parametroEscola = new ParametrosEscola { NomeEscola = "Só para Nerds", MediaAprovacao = 9 };

            var tipoDeCalculo = TipoDeCalculo();

            var calculaMedias = new CalculoMedias(parametroEscola);
            calculaMedias.Nota1 = dadosIo.SolicitarValorDecimalAoUsuario("Digite a primeira nota", 0, 10);
            calculaMedias.Nota2 = dadosIo.SolicitarValorDecimalAoUsuario("Digite a segunda nota", 0, 10);
            calculaMedias.Nota3 = dadosIo.SolicitarValorDecimalAoUsuario("Digite a terceira nota", 0, 10);

            var media = calculaMedias.Calcular(tipoDeCalculo);
            var passou = calculaMedias.Passou(media);
            var status = passou ? "aprovado" : "reprovado";

            Console.WriteLine($"A sua média é de {Math.Round(media, 2)}. Você foi {status}. A média de aprovação na {parametroEscola.NomeEscola} é de {Math.Round(parametroEscola.MediaAprovacao, 2)}");
        }
        private static decimal TipoDeEscola()
        {
            Console.WriteLine("Escolha a escola que deseja calcular a média");
            Console.WriteLine("1 - Escola Molezinha da Estrela");
            Console.WriteLine("2 - Escola nem lá nem cá");
            Console.WriteLine("3 - Escola só para os Nerds");
            Console.Write("Digite: ");
            var opcao = Convert.ToDecimal(Console.ReadLine());
            return opcao;
        }
        private static decimal TipoDeCalculo()
        {

            Console.WriteLine("Escolha uma opção por números");
            Console.WriteLine("1 - Média aritimética");
            Console.WriteLine("2 - Média ponderada");
            Console.WriteLine("3 - Média harmônica");
            Console.Write("Digite: ");
            var opcao = Convert.ToDecimal(Console.ReadLine());
            return opcao;
        }
    }
    public class ParametrosEscola
    {
        public string NomeEscola { get; set; }
        public decimal MediaAprovacao { get; set; }
    }
    public class CalculoMedias
    {
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal NotaResultado { get; set; }
        public ParametrosEscola ParametroEscola { get; }
        public CalculoMedias(ParametrosEscola parametroEscola)
        {
            ParametroEscola = parametroEscola;
        }
        public decimal Calcular(decimal opcao)
        {
            switch (opcao)
            {
                case 1:
                    NotaResultado = (Nota1 + Nota2 + Nota3) / 3;
                    break;
                case 2:
                    NotaResultado = ((Nota1 * 3) + (Nota2 * 3) + (Nota3 * 4)) / 10;
                    break;
                case 3:
                    NotaResultado = 3 / ((1 / Nota1) + (1 / Nota2) + (1 / Nota3));
                    break;
            }
            return NotaResultado;
        }
        public bool Passou(decimal media) => (media >= ParametroEscola.MediaAprovacao);
    }
}

