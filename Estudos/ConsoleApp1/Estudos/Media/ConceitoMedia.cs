using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos.Media
{
    public class ConceitoMedia
    {
        public static void Processar()
        {
            var dadosIo = new DadosIo();
            var calculaMediaConceito = new CalculaMediaConceito();

            calculaMediaConceito.Identificacao = dadosIo.SolicitarValorInteiroAoUsuario("Digite o seu número de identificação", 0, 10000);
            calculaMediaConceito.Nota1 = dadosIo.SolicitarValorDecimalAoUsuario("Digite a primeira nota", 0, 10);
            calculaMediaConceito.Nota2 = dadosIo.SolicitarValorDecimalAoUsuario("Digite a segunda nota", 0, 10);
            calculaMediaConceito.Nota3 = dadosIo.SolicitarValorDecimalAoUsuario("Digite a terceira nota", 0, 10);

            calculaMediaConceito.MediaAproveitamento = calculaMediaConceito.CalculaMediaAproveitamento();
            calculaMediaConceito.Conceito = calculaMediaConceito.DeterminaConceito();

            var mensagemAprovacao = "Parabéns, você foi aprovado. ";
            var mensagemReprovacao = "Meus sentimentos, você foi reprovado. ";
            var mensagemIdentificacao = "Sua identificação é ";
            var mensagemMedia = "sua média foi ";
            var mensagemMediaAproveitamento = ", sua média de aproveitamento foi de ";
            var mensagemConceito = " e seu conceito foi de ";

            //var arrayMensagens = ["Parabéns"];

            Console.WriteLine();
            if (calculaMediaConceito.Conceito == "A" || calculaMediaConceito.Conceito == "B" || calculaMediaConceito.Conceito == "C")
            {
                Console.WriteLine(mensagemAprovacao + mensagemIdentificacao + $"{calculaMediaConceito.Identificacao}, " + mensagemMedia
                    + $"{calculaMediaConceito.Media}" + mensagemMediaAproveitamento +
                    $"{calculaMediaConceito.MediaAproveitamento}" + mensagemConceito + $"{calculaMediaConceito.Conceito}");
            }
            else
            {
                Console.WriteLine(mensagemReprovacao + mensagemIdentificacao + $"{calculaMediaConceito.Identificacao}, " + mensagemMedia
                    + $"{calculaMediaConceito.Media}" + mensagemMediaAproveitamento +
                    $"{calculaMediaConceito.MediaAproveitamento}" + mensagemConceito + $"{calculaMediaConceito.Conceito}");
            }
        }
    }
    public class CalculaMediaConceito
    {
        public long Identificacao { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Media { get; set; }
        public decimal MediaAproveitamento { get; set; }
        public string Conceito { get; set; }

        public decimal CalculaMediaAproveitamento()
        {
            Media = Math.Round((Nota1 + Nota2 + Nota3) / 3, 2);
            MediaAproveitamento = Math.Round((Nota1 + (Nota2 * 2) + (Nota3 * 3) + Media) / 7, 2);

            return MediaAproveitamento;
        }
        public string DeterminaConceito()
        {
            Conceito = "A";

            if (MediaAproveitamento > 9)
                Conceito = "A";
            else if (MediaAproveitamento > 7.5m)
                Conceito = "B";
            else if (MediaAproveitamento > 6)
                Conceito = "C";
            else if (MediaAproveitamento > 4)
                Conceito = "D";
            else if (MediaAproveitamento > 0)
                Conceito = "E";

            return Conceito;
        }
    }

}