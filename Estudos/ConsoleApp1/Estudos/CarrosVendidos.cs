using System.Security.Cryptography;

namespace ConsoleApp1.Estudos
{
    public class CarrosVendidos
    {
        public static void Processar()
        {
            var salario = ObterValores("Digite o salário: ");
            var carrosVendidos = ObterValores("Digite quantos carros foram vendidos: ");
            var valorVendas = ObterValores("Digite o valor total dos carros vendidos: ");
            var valorComissao = ObterValores("Digite o valor fixo da comissão: ");
            var novoSalario = calculaSalario(salario, carrosVendidos, valorVendas, valorComissao);
            Console.WriteLine($"O salário desse mês é de {novoSalario}");
        }
        private static decimal ObterValores(string descricao)
        {
            Console.Write(descricao);
            var dados = Convert.ToInt32(Console.ReadLine());
            while (dados < 0)
            {
                Console.WriteLine(descricao);
                dados = Convert.ToInt32(Console.ReadLine());
            }
            return dados;
        }

        private static decimal calculaSalario(decimal salario, decimal carrosVendidos, decimal valorVendas, decimal valorComissao)
        {
            var percentualVendas = valorVendas / 0.5m;
            var valorFixo = valorComissao * carrosVendidos;
            return salario + percentualVendas + valorFixo;
        }
    }
}