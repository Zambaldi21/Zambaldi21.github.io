namespace ConsoleApp1.Estudos
{
    public class InteiroOuDecimal
    {
        public static void Processar()
        {
            Console.WriteLine("Digite um número.");
            var numero = Console.ReadLine();
            
            var numeroDecimal = Decimal.TryParse(numero, out var result) ? result : 0;

            var numeroInteiro = Convert.ToInt32(numeroDecimal);
            if (numeroDecimal == numeroInteiro)
            {
                Console.WriteLine($"O número {numeroDecimal} é inteiro");
            }
            else
            {
                Console.WriteLine($"O número {numeroDecimal} não é inteiro");
            }

        }
    }
}