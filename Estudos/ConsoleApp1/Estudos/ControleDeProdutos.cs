using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class ControleDeProdutos
    {
        public static void Processar()
        {
            //Declara objetos
            var dadosIo = new DadosIo();

            //Input
            Console.WriteLine();
        }
    }

    public class CalculoProdutos
    {
        public int KitMotorista { get; set; }
        public int PaoMotorista { get; set; }
        public int CafeMotorista { get; set; }
        public int AguaMotorista { get; set; }
        public int KitTrabalhadores { get; set; }
        public int PaoTrabalhadores { get; set; }
        public int CafeTrabalhadores { get; set; }
        public int AguaTrabalhadores { get; set; }
        public int Resultado { get; set; }

        public int CalcularMotorista
            ()
        {

            return Resultado;
        }


    }
}
