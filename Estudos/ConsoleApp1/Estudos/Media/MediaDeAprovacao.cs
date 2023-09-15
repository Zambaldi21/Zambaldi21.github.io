using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1.Estudos.Media
{
    public class MediaDeAprovacao
    {
        const int notaLimite = 10;

        public static void Processar()
        {
            var n1 = DigitarNota("Primeira");
            var n2 = DigitarNota("Segunda");
            var n3 = DigitarNota("Terceira");
            var n4 = DigitarNota("Quarta");

            var media = (n1 + n2 + n3 + n4) / 4;
            const int mediaDeAprovacao = 8;

            if (media < mediaDeAprovacao)
            {
                var faltaramPontos = mediaDeAprovacao - media;
                Console.WriteLine($"Sinto muito, mas você não alcançou a média. Faltou(ram) {faltaramPontos} pontos.");
            }
            else
            {
                var maiorNota = n1;
                if (n2 > maiorNota)
                {
                    maiorNota = n2;
                }
                if (n3 > maiorNota)
                {
                    maiorNota = n3;
                }
                if (n4 > maiorNota)
                {
                    maiorNota = n4;
                }
                Console.WriteLine($"Parabéns, você foi aprovado. Sua média foi de {media} e sua maior nota foi {maiorNota}");
            }
        }

        private static decimal DigitarNota(string descricaoNota)
        {
            Console.WriteLine($"Digite a {descricaoNota} nota");
            var nota = Convert.ToDecimal(Console.ReadLine());
            while ((nota < 0) || (nota > notaLimite))
            {
                Console.WriteLine($"Não são aceitas notas maiores que {notaLimite}. Digite novamente.");
                Console.WriteLine($"Digite a {descricaoNota} nota");
                nota = Convert.ToDecimal(Console.ReadLine());
            }
            return nota;
        }
    }
}