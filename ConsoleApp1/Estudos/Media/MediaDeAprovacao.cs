using ConsoleApp1.Utils;
namespace ConsoleApp1.Estudos.Media
{
    public class MediaDeAprovacao
    {
        public static void Processar()
        {
            var dadosIo = new DadosIo();
            var calculoMedia = new CalculoMedia();

            calculoMedia.Nota1 = dadosIo.SolicitarValorDecimalAoUsuario("Digite a primeira nota do aluno: ", 0, 10);
            calculoMedia.Nota2 = dadosIo.SolicitarValorDecimalAoUsuario("Digite a segunda nota do aluno: ", 0, 10);
            calculoMedia.Nota3 = dadosIo.SolicitarValorDecimalAoUsuario("Digite a terceira nota do aluno: ", 0, 10);

            var resultado = calculoMedia.CalcularMedia(calculoMedia.Nota1, calculoMedia.Nota2, calculoMedia.Nota3);

            if (resultado > 7)
            {
                Console.WriteLine($"Parabéns, você foi aprovado. Sua média é: {resultado:F2}");
            }
            else
            {
                Console.WriteLine($"Poxa, você foi reprovado. Sua média é: {resultado:F2}");
            }

        }
    }

    public class CalculoMedia
    {
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Media { get; set; }

        public decimal CalcularMedia(decimal nota1, decimal nota2, decimal nota3)
        {
            Media = (Nota1 + Nota2 + Nota3) / 3;
            return Media;
        }
    }
}
