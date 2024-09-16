using ConsoleApp1.Utils;
namespace ConsoleApp1.Estudos
{
    public class HorasExtras
    {
        public static void Processar()
        {
            //inputs
            var dadosIo = new DadosIo();

            Console.WriteLine("Considere minutos até 59.");
            var cargaHorariaColaborador = dadosIo.SolicitarValorInteiroAoUsuario("Digite se você é 4 horas ou 6 horas: ");
            var horaEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você entrou: ");
            var minutoEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você entrou: ", 0, 59);
            var horaSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você saiu: ");
            var minutoSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você saiu: ", 0, 59);

            //process
            var horarioEntrada = DateTime.Today.AddHours(horaEntrada).AddMinutes(minutoEntrada);
            var horarioSaida = DateTime.Today.AddHours(horaSaida).AddMinutes(minutoSaida);
            var tempoTrabalhado = horarioSaida - horarioEntrada;
            var jornadaDeTrabalho = TimeSpan.FromHours(cargaHorariaColaborador);
            var horasExtras = tempoTrabalhado.Subtract(jornadaDeTrabalho);

            if (horasExtras.Ticks <= 0)
            {
                Console.WriteLine("Você não possui horas extras.");
            }
            else
            {
                Console.WriteLine($"Voce possui {horasExtras} horas extras.");
            }
        }
    }
}
