using System.Reflection.Metadata;

namespace ConsoleApp1.Estudos.Conversao
{
    public class HorasJogo
    {
        public static void Processar()
        {
            var horaInicio = obterHoras("começou");
            var horaFim = obterHoras("terminou");
            var horasJogadas = calcularHorasJogo(horaInicio, horaFim);
            Console.WriteLine($"Você jogou {horasJogadas} hora(s).");
        }

        private static int obterHoras(string acao)
        {
            Console.WriteLine($"Digite o horário que {acao} o jogo.");
            var hora = Convert.ToInt32(Console.ReadLine());
            while (hora < 0 || hora > 23)
            {
                Console.WriteLine($"Não é aceito um horário maior que 23 e menor que 0. Por favor, digite novamente o horário que {acao} o jogo.");
                hora = Convert.ToInt32(Console.ReadLine());
            }
            return hora;
        }

        private static int calcularHorasJogo(int inicio, int fim)
        {
            return inicio > fim ? fim + 24 - inicio : fim - inicio;
        }
    }
}