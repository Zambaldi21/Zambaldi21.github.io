using System.Reflection;

namespace ConsoleApp1.Estudos
{
    public class ConversaoHora
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o total de segundos passados no evento.");
            var totalDeSegundos = Convert.ToInt32(Console.ReadLine());
            const int conversaoMinutos = 60;
            const int conversaoSegundos = 3600;

            var horasPassadas = (totalDeSegundos/ conversaoSegundos);
            totalDeSegundos = totalDeSegundos % conversaoSegundos;

            var MinutosPassados = (totalDeSegundos/conversaoMinutos);
            var segundos = totalDeSegundos % conversaoMinutos;

            Console.WriteLine($"O evento durou {horasPassadas} horas, {MinutosPassados} minutos e {segundos} segundos.");
        }
    }
}