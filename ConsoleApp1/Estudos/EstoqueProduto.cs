namespace ConsoleApp1.Estudos
{
    public class EstoqueProduto
    {
        public static void Processar()
        {
            var quantidadeAtual = ObterDados("Digite a quantidade atual do seu produto.");
            var quantidadeMaxima = ObterDados("Digite a quantidade máxima do seu produto.");
            var quantidadeMinina = ObterDados("Digite a quantidade mínima do seu produto.");

            var quantidadeMedia = ((quantidadeMaxima - quantidadeMinina));
        }


        private static int ObterDados(string descricao)
        {
            Console.WriteLine(descricao);
            var opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
    }
}