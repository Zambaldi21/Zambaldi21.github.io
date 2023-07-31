namespace ConsoleApp1.Estudos
{
    public class ConversaoIdade
    {
        public static void Processar()
        {
            Console.WriteLine("Digite sua idade em dias.");
            var idadeTotal = Convert.ToInt32(Console.ReadLine());

            const int conversaoAno = 365;
            const int conversaoMes = 30;

            var anos = idadeTotal / conversaoAno;
            idadeTotal = idadeTotal % conversaoAno;

            var mes = idadeTotal / conversaoMes;

            var dias = idadeTotal % conversaoMes;

            Console.WriteLine($"Você tem {anos} ano(s), {mes} mes(es) e {dias} dia(s).");
        }
    }
}