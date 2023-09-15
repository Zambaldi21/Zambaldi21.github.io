using ConsoleApp1.Utils;
using System.Reflection;

namespace ConsoleApp1.Estudos
{
    public class ConversaoHora
    {
        public static void Processar()
        {

            var dadosIo = new DadosIo();
            var tempo = new Tempo();

            tempo.Segundos = dadosIo.SolicitarValorDecimalAoUsuario("Digite o total de segundos passados no evento");
            tempo.Horas = tempo.TempoHoras();
            tempo.Minutos = tempo.TempoMinutos();
            tempo.Segundos = tempo.TempoSegundos();

            Console.WriteLine($"O evento durou {Math.Round(tempo.Horas, 0)} hora(s), {Math.Round(tempo.Minutos, 0)} minuto(s) e {tempo.Segundos} segundo(s).");
        }
    }
    public class Tempo
    {
        const int conversaoMinutos = 60;
        const int conversaoSegundos = 3600;
        public decimal Segundos { get; set; }
        public decimal Minutos { get; set; }
        public decimal Horas { get; set; }

        public decimal TempoHoras()
        {
            Horas = (Segundos / conversaoSegundos);
            Segundos = Segundos % conversaoSegundos;

            return Horas;
        }
        public decimal TempoMinutos()
        {
            Minutos = (Segundos / conversaoMinutos);

            return Minutos;
        }
        public decimal TempoSegundos()
        {
            var segundosTotais = Segundos % conversaoMinutos;

            return segundosTotais;
        }
    }
}