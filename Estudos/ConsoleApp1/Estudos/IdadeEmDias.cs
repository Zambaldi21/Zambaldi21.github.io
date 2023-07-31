namespace ConsoleApp1.Estudos
{
    public class IdadeEmDias
    {
        public static void Processar()
        {
            Console.WriteLine("Digite sua idade em anos.");
            var idadeEmAnos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua idade em meses que ainda não completaram um ano.");
            var idadeEmMeses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua idade em dias que ainda não completaram um mês.");
            var idadeEmDias = Convert.ToInt32(Console.ReadLine());
            var idadeAnosDias = Convert.ToInt32(idadeEmAnos * 365);
            var idadeMesDias = Convert.ToInt32(idadeEmMeses * 30);
            var diasDeVida = Convert.ToInt32(idadeAnosDias + idadeMesDias + idadeEmDias);
            Console.WriteLine($"O total dos seus dias de vida são {diasDeVida}.");
        }
    }
}