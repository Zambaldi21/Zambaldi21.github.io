namespace ConsoleApp1.Estudos
{
    public class DistanciaEntrePontos
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o x1.");
            var x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o y2.");
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o x2.");
            var x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o y2.");
            var y2 = Convert.ToDouble(Console.ReadLine());

            var valorReal = (Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            var distancia = Math.Round(Math.Sqrt(valorReal), 2);

            Console.WriteLine($"A distância entre esses dois pontos é {distancia}");
        }
    }
}