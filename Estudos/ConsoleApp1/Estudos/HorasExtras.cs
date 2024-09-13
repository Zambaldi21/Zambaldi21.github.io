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
            var solicitaHorarioColaborador = dadosIo.SolicitarValorInteiroAoUsuario("Digite se você é 4 horas ou 6 horas: ");
            var solicitaHoraEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você entrou: ");
            var solicitaMinutoEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você entrou: ", 59);
            var solicitaHoraSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você saiu: ");
            var solicitaMinutoSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você saiu: ", 59);

            //process
            var converteMinutoHoraEntrada = solicitaMinutoEntrada / 60;
            var converteMinutoHoraSaida = solicitaMinutoSaida / 60;
            var calcula = (solicitaHoraEntrada + converteMinutoHoraEntrada) - (solicitaHoraSaida + converteMinutoHoraSaida);

            if (solicitaHorarioColaborador == 4)
            {
                var resultado = calcula - 4;
            }
            else if (solicitaHorarioColaborador == 6)
            {
                var resultado = calcula - 6;
            }
            else if (solicitaHorarioColaborador <= 4 || solicitaHorarioColaborador <= 6)
            {
                Console.WriteLine("Você não possui horas extras.");
            }
            //output
            Console.WriteLine("Voce");
        }
    }
}
