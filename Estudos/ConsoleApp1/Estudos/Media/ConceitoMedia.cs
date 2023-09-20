using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos.Media
{
    public class ConceitoMedia
    {
        public static void Processar()
        {
            var dadosIo = new DadosIo();

            
            Console.Write($"Digite o seu número de identificação. Siga o exemplo: 1234: ");
            var identificacao = Convert.ToInt32(Console.ReadLine());

            var nota1 = ObterNota("primeira");
            var nota2 = ObterNota("segunda");
            var nota3 = ObterNota("terceira");
            var mediaExercicios = Math.Round((nota1 + nota2 + nota3) / 3, 2);
            var MediaAproveitamento = Math.Round((nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7, 2);
            var conceito = DeterminaConceito(MediaAproveitamento);
            Console.WriteLine();
            if (conceito == "A" || conceito == "B" || conceito == "C")
            {
                Console.WriteLine($"Parabéns, você foi aprovado. Sua identificação é {identificacao} Sua média foi de {mediaExercicios}, sua média de aproveitamento foi de {MediaAproveitamento} e seu conceito foi de {conceito}");
            }
            else
            {
                Console.WriteLine($"Meus sentimentos, você foi reprovado. Sua identificação é {identificacao} Sua média foi de {mediaExercicios}, sua média de aproveitamento foi de {MediaAproveitamento} e seu conceito foi de {conceito}");
            }
        }

        private static decimal ObterNota(string descreverNota)
        {
            Console.Write($"Digite a sua {descreverNota} nota: ");
            var nota = Convert.ToDecimal(Console.ReadLine());
            while (nota < 0 || nota > 10)
            {
                Console.Write("Não são aceitas notas maiores que 10 ou menores que 0. Por favor, digite novamente: ");
                nota = Convert.ToDecimal(Console.ReadLine());
            }
            return nota;
        }
        private static string DeterminaConceito(decimal mediaAproveitamento)
        {
            var conceito = "A";

            if (mediaAproveitamento > 9)
                conceito = "A";
            else if (mediaAproveitamento > 7.5m)
                conceito = "B";
            else if (mediaAproveitamento > 6)
                conceito = "C";
            else if (mediaAproveitamento > 4)
                conceito = "D";
            else if (mediaAproveitamento > 0)
                conceito = "E";

            return conceito;
        }
    }
}