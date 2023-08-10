namespace ConsoleApp1.Estudos
{
    public class CaixaEletronico
    {
        public static void Processar()
        {
            Console.WriteLine("As cédulas disponíveis para saque são de R$ 100,00; R$ 50,00; R$ 20,00; R$10,00.");
            Console.WriteLine("Digite o valor do seu saque.");
            var saque = Convert.ToDecimal(Console.ReadLine());

            var entregarSaque = saque;

            entregarSaque = entregarCedulas(entregarSaque, 100);
            entregarSaque = entregarCedulas(entregarSaque, 50);
            entregarSaque = entregarCedulas(entregarSaque, 20);
            entregarSaque = entregarCedulas(entregarSaque, 10);
        }

        private static decimal entregarCedulas(decimal saque, decimal cedula)
        {
            while (saque >= cedula)
            {
                Console.WriteLine($"Pegue uma cédula de {cedula}.");
                saque = saque - cedula;
            }
            return saque;
        }
    }
}