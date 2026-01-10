using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class PesoIdeal
    { //TO DO
        public static void Processar()
        {
            var dadosIo = new DadosIo();
            var calculaPeso = new CalculaPeso();

            Console.WriteLine("Digite seu gênero.");
            calculaPeso.Genero = calculaPeso.DefineGenero("Para Feminino digite 1 e para Masculino digite 2");
            calculaPeso.Altura = dadosIo.SolicitarValorDecimalAoUsuario("Digite sua altura em metros, ex.1,71", 0);
            calculaPeso.Peso = calculaPeso.CalculoPeso();

            Console.WriteLine($"O seu peso ideal é: {calculaPeso.Peso}");
            dadosIo.saida($"O seu peso ideal é: {calculaPeso.Peso}");
        }
    }
    public class CalculaPeso
    {
        public decimal Altura { get; set; }
        public decimal Genero { get; set; }
        public decimal Peso { get; set; }
        public decimal DefineGenero(string descricao)
        {
            Console.WriteLine(descricao);
            Genero = Convert.ToDecimal(Console.ReadLine());
            return Genero;
        }
        public decimal CalculoPeso()
        {
            switch (Genero)
            {
                case 1: // Case Peso Feminino
                    Peso = Math.Round(((62.1M * Altura) - 44.7M), 2);
                    break;
                case 2:// Case Peso Masculino
                    Peso = Math.Round(((72.7M * Altura) - 58M), 2);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            return Peso;
        }
    }
}