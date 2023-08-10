namespace ConsoleApp1.Estudos
{
    public class MediaPeso
    {
        public static void Processar()
        {
            var n1 = DigitarNota("primeira");
            var n2 = DigitarNota("segunda");
            var n3 = DigitarNota("terceira");
            var media = CalcularMedia(n1, n2, n3);
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

        private static decimal CalcularMedia(decimal n1, decimal n2, decimal n3)
        {
            var media = Math.Round((((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10), 2);
            Console.WriteLine($"Sua média foi de {media}.");
            return media;
        }


    }
}