using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class DistanciaEntrePontos
    {
        public static void Processar()
        {
            //Instancia classes
            var dadosIo = new DadosIo();
            var calcularDistancia = new CalcularDistancia();

            //Inputs
            calcularDistancia.X1 = Convert.ToDouble(dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor de x1: "));
            calcularDistancia.X2 = Convert.ToDouble(dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor de x2: "));
            calcularDistancia.Y1 = Convert.ToDouble(dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor de y1: "));
            calcularDistancia.Y2 = Convert.ToDouble(dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor de y2: "));

            //Process
            calcularDistancia.Resultado();

            //Output
            Console.WriteLine();
            Console.WriteLine($"A distância entre esses dois pontos é {calcularDistancia.Distancia}");
        }
    }
    public class CalcularDistancia
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public double Distancia { get; private set; }

        public double Resultado()
        {
            Distancia = CalculaDistancia();
            return Distancia;
        }
        private double CalculaDistancia() => Math.Round(Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2))), 2);
    }
}