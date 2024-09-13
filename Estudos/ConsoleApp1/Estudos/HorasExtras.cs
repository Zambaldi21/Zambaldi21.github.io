using ConsoleApp1.Utils;
namespace ConsoleApp1.Estudos
{
    public class HorasExtras
    {
        public static void Processar()
        {
            var colaborador = new Colaborador { Nome = "Juan", CargaHorariaMensal = 144 };
            var dadosIo = new DadosIo();


            var entrada = dadosIo.SolicitarDataComHoraAoUsuario("Informe a hora de entrada");
            var saida = dadosIo.SolicitarDataComHoraAoUsuario("Informe a hora de saída");
            colaborador.RegistrarExpediente(entrada, saida);



            var horasExtras = colaborador.CalcularHorasExtras();
            Console.WriteLine($"HorasExtras: {horasExtras}");


            //inputs
            //var dadosIo = new DadosIo();

            //Console.WriteLine("Considere minutos até 59.");
            //var solicitaHorarioColaborador = dadosIo.SolicitarValorInteiroAoUsuario("Digite se você é 4 horas ou 6 horas: ");
            //var solicitaHoraEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você entrou: ");
            //var solicitaMinutoEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você entrou: ", 59);
            //var solicitaHoraSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você saiu: ");
            //var solicitaMinutoSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você saiu: ", 59);

            ////process
            //var converteMinutoHoraEntrada = solicitaMinutoEntrada / 60;
            //var converteMinutoHoraSaida = solicitaMinutoSaida / 60;
            //var calcula = (solicitaHoraEntrada + converteMinutoHoraEntrada) - (solicitaHoraSaida + converteMinutoHoraSaida);

            //if (solicitaHorarioColaborador == 4)
            //{
            //    var resultado = calcula - 4;
            //}
            //else if (solicitaHorarioColaborador == 6)
            //{
            //    var resultado = calcula - 6;
            //}
            //else if (solicitaHorarioColaborador <= 4 || solicitaHorarioColaborador <= 6)
            //{
            //    Console.WriteLine("Você não possui horas extras.");
            //}
            ////output
            //Console.WriteLine("Voce");
        }
    }


    public class Colaborador
    {
        public long CPF { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public int CargaHorariaMensal { get; set; }
        public decimal? ValorHoraExtra { get; set; }
        public List<Expediente> Expedientes { get; set; }

        public Colaborador()
        {
            Expedientes = new List<Expediente>();
        }

        public void RegistrarExpediente(DateTime dataEntrada, DateTime dataSaida)
        {
            var expediente = new Expediente
            {
                Colaborador = this,
                Entrada = dataEntrada,
                Saida = dataSaida
            };
            Expedientes.Add(expediente);
        }

        public int CalcularHorasExtras()
        {
            var totalHorasTrabalhadas = Expedientes.Sum(e => e.TotalHorasTrabalhadas.TotalHours);

            var horasExtras = Convert.ToInt32(totalHorasTrabalhadas) - CargaHorariaMensal;

            return horasExtras;
        }
    }

    public class Expediente
    {
        public Colaborador Colaborador { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public TimeSpan TotalHorasTrabalhadas => Saida - Entrada;
    }

}