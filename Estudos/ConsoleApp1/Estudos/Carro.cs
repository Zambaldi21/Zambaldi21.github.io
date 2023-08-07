namespace ConsoleApp1.Estudos
{
    public class Carro
    {
        public static void Processar()
        {
            var percentualCusto = ObterPercentual("PercentualCusto");
            var percentualImpostos = ObterPercentual("PercentualImpostos");

            Console.WriteLine("Digite o valor do custo de fábrica.");
            var custoDeFabrica = Convert.ToDecimal(Console.ReadLine());
            var custoDistribuidor = Convert.ToDecimal(percentualCusto * custoDeFabrica);
            var impostos = Convert.ToDecimal(percentualImpostos * custoDeFabrica);
            var custoAoConsumidor = custoDeFabrica + custoDistribuidor + impostos;
            Console.WriteLine($"O valor do carro com as taxas extras é de {custoAoConsumidor}");

        }

        private static decimal ObterPercentual(string resource)
        {
            var endereco = "http://localhost:7100/api/";
            var httpClient = new HttpClient { BaseAddress = new Uri(endereco) };

            var response = httpClient.GetAsync(resource).GetAwaiter().GetResult();
            var percentualCusto = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            return decimal.Parse(percentualCusto);
        }
    }
}