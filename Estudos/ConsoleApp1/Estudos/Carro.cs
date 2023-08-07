namespace ConsoleApp1.Estudos
{
    public class Carro
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o valor do custo de fábrica.");
            var custoDeFabrica = Convert.ToDecimal(Console.ReadLine());
            var custoDistribuidor = Convert.ToDecimal((28m / 100m) * custoDeFabrica);
            var impostos = Convert.ToDecimal((45m /100m) * custoDeFabrica);
            var custoAoConsumidor = custoDeFabrica + custoDistribuidor + impostos;
            Console.WriteLine($"O valor do carro com as taxas extras é de {custoAoConsumidor}");

        }
    }
}