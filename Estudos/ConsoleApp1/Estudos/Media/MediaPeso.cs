namespace ConsoleApp1.Estudos.Media
{
    public class MediaPeso
    {
        public static void Processar()
        {
            var mediaNotas = new MediaNotas();

            mediaNotas.Nota1 = DigitarNota("Primeira");
            mediaNotas.Nota2 = DigitarNota("Segunda");
            mediaNotas.Nota3 = DigitarNota("Terceira");

            var media = mediaNotas.CalcularMedia();

            Console.WriteLine($"Sua média foi de {media}.");
        }

        private static decimal DigitarNota(string especificarNota)
        {
            Console.WriteLine($"Digite a {especificarNota} nota.");
            var nota = Convert.ToDecimal(Console.ReadLine());
            while ((nota < 0) || (nota > 10))
            {
                Console.WriteLine($"Não são aceitas notas maiores ou menores do que dez. Por favor, digite a {especificarNota} nota novamente.");
                nota = Convert.ToDecimal(Console.ReadLine());
            }
            return nota;
        }
    }
    public class MediaNotas
    {
        public decimal Nota1;
        public decimal Nota2;
        public decimal Nota3;

        public decimal CalcularMedia()
        {
            return CalcularMedia(Nota1, Nota2, Nota3);
        }

        private decimal CalcularMedia(decimal n1, decimal n2, decimal n3)
        {
            var media = Math.Round((((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10), 2);
            return media;
        }
    }
}