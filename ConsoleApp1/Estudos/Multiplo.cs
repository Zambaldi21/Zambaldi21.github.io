namespace ConsoleApp1.Estudos
{
    public class Multiplo
    {
        public static void Processar()
        {
            Console.WriteLine("Digite um valor");
            var numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um valor");
            var numero2 = Convert.ToInt32(Console.ReadLine());

            var resto = numero1 % numero2;

            if (resto == 0)
            {
                Console.WriteLine($"O {numero1} é múltiplo do {numero2}.");
            }
            else
            {
                Console.WriteLine($"O {numero1} não é múltiplo do {numero2}.");
            }
        }
    }
}