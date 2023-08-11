namespace ConsoleApp1.Estudos
{
    public class HorasJogo
    {
        public static void Processar()
        {
            var horaInicio = 0;
            var horaFim = 0;
            var jogoInicio = DigitarHoras(horaInicio, horaFim);

            //var horasJogadas = calcularHorasJogo(horaInicio, horaFim);
            //Console.WriteLine($"Você jogou {horasJogadas} horas.");
        }

        private static decimal DigitarHoras(decimal horaInicio, decimal horaFim)
        {
            Console.WriteLine("Digite o horário que começou a jogar, em horas.");
            horaInicio = Convert.ToDecimal(Console.ReadLine());
            while (horaInicio < 0 && horaInicio > 24)
            {
                Console.WriteLine("As horas não podem ser menores do que 0. Por favor digite a hora do que começou a jogar novamente.");
                horaInicio = Convert.ToDecimal(Console.ReadLine());
            }
            Console.WriteLine("Digite o horário que terminou de jogar, em horas.");
            horaInicio = Convert.ToDecimal(Console.ReadLine());
            return horaInicio;
        }


        private static decimal calcularHorasJogo(decimal horaInicio, decimal horaFim)
        {
            var horasJogadas = horaFim - horaInicio;

            while ((horaFim > 24 && horaFim < 0) || (horaInicio > 24 && horaInicio < 0))
            {
                horasJogadas = horaFim - horaInicio;
            }
            return horasJogadas;
        }
    }
}