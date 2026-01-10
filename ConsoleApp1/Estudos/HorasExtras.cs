using ConsoleApp1.Utils;
namespace ConsoleApp1.Estudos
{
    public class HorasExtras
    {
        public static void Processar()
        {
            var dadosIo = new DadosIo();

            Console.WriteLine("Considere minutos até 59.");
            var cargaHorariaDiaria = dadosIo.SolicitarValorInteiroAoUsuario("Qual é a sua carga horária diária: ", 4, 6);
            var diasPorMes = dadosIo.SolicitarValorInteiroAoUsuario("Quantos dias você trabalho por mês: ", 16, 30);
            var colaborador = new Colaborador { Nome = "Juan", CargaHorariaMensal = cargaHorariaDiaria * diasPorMes };

            var resposta = dadosIo.SolicitarStringAoUsuario("Deseja registrar um horário? [S / N]");
            while (resposta.ToUpper().Equals("S"))
            {
                var horaEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você entrou: ");
                var minutoEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você entrou: ", 0, 59);
                var horaSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você saiu: ");
                var minutoSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você saiu: ", 0, 59);
                var horarioEntrada = DateTime.Today.AddHours(horaEntrada).AddMinutes(minutoEntrada);
                var horarioSaida = DateTime.Today.AddHours(horaSaida).AddMinutes(minutoSaida);

                //process
                colaborador.RegistrarExpediente(horarioEntrada, horarioSaida);
                
                resposta = dadosIo.SolicitarStringAoUsuario("Deseja registrar mais um horário? [S / N]");
            }

            var horasExtras = colaborador.CalcularHorasExtras();
            Console.WriteLine($"HorasExtras: {horasExtras}");


            //inputs
            //var dadosIo = new DadosIo();

            //Console.WriteLine("Considere minutos até 59.");
            //var cargaHorariaColaborador = dadosIo.SolicitarValorInteiroAoUsuario("Digite se você é 4 horas ou 6 horas: ");
            //var horaEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você entrou: ");
            //var minutoEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você entrou: ", 0, 59);
            //var horaSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que você saiu: ");
            //var minutoSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que você saiu: ", 0, 59);

            ////process
            //var horarioEntrada = DateTime.Today.AddHours(horaEntrada).AddMinutes(minutoEntrada);
            //var horarioSaida = DateTime.Today.AddHours(horaSaida).AddMinutes(minutoSaida);
            //var tempoTrabalhado = horarioSaida - horarioEntrada;
            //var jornadaDeTrabalho = TimeSpan.FromHours(cargaHorariaColaborador);
            //var horasExtras = tempoTrabalhado.Subtract(jornadaDeTrabalho);

            //if (horasExtras.Ticks <= 0)
            //{
            //    Console.WriteLine("Você não possui horas extras.");
            //}
            //else
            //{
            //    Console.WriteLine($"Voce possui {horasExtras} horas extras.");
            //}
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