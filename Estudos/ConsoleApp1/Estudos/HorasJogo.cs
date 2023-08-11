using System.Reflection.Metadata;

namespace ConsoleApp1.Estudos
{
    public class HorasJogo
    {
        public static void Processar()
        {
            var horaInicio = digitarHorasInicio();
            var horaFim = digitarHorasFim();
            var horasJogadas = calcularHorasJogo(horaInicio, horaFim);
            Console.WriteLine($"Você jogou {horasJogadas} hora(s).");


        }

        private static int digitarHorasInicio()
        {
            Console.WriteLine("Digite o horário que começou a jogar.");
            var inicioJogo = Convert.ToInt32(Console.ReadLine());
            while ((inicioJogo < 0) || (inicioJogo > 23))
            {
                Console.WriteLine("Não é aceito um horário maior que 23 e menor que 0. Por favor, digite novamente o horário de início do jogo.");
                inicioJogo = Convert.ToInt32(Console.ReadLine());

            }
            return inicioJogo;
        }
        private static int digitarHorasFim()
        {
            Console.WriteLine("Digite o horário que terminou de jogar.");
            var FimJogo = Convert.ToInt32(Console.ReadLine());
            while ((FimJogo < 0) || (FimJogo > 23))
            {
                Console.WriteLine("Não é aceito um horário maior que 23 e menor que 0. Por favor, digite novamente o horário de início do jogo.");
                FimJogo = Convert.ToInt32(Console.ReadLine());

            }
            return FimJogo;
        }
        private static int calcularHorasJogo(int inicio, int fim)
        {
            var horasJogadas = fim - inicio;
            if (inicio > fim)
            {
                horasJogadas = ((fim  - inicio) + 24);
            }
            else
            {
                horasJogadas = fim - inicio;
            }
            return horasJogadas;
        }
    }
}