using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1.Estudos
{
    public class Investimento
    {
        public static void Processar()
        {
            var calculoValores = new CalculoValores();

            calculoValores.DinheiroAplicado = DigitarDados("Digite o valor aplicado no investimento");
            calculoValores.TempoInvestido = DigitarDados("Digite o tempo de investimento");
            calculoValores.TaxaJuros = DigitarDados("Digite a taxa de juros no investimento");

            calculoValores.CalculaInvestimento();

            Console.WriteLine($"O seu ganho foi de R${calculoValores.ValorLucro} e o percentual foi de {calculoValores.PercentualLucro}%");
        }

        private static decimal DigitarDados(string descricao)
        {
            Console.WriteLine(descricao);
            var dado = Convert.ToDecimal(Console.ReadLine());
            return dado;
        }




    }


    /// <summary>
    /// Faça um programa que calcule o valor e  o percentual de lucros de um investidor que deseja investir um determinado valor por um determinado tempo.
    /// A taxa de juros, o tempo e o valor serão informados pelo investidor.
    /// O investimento será contabilizado a uma taxa de juros simples.
    /// </summary>
    public class CalculoValores
    {
        public decimal DinheiroAplicado;
        public decimal TaxaJuros;
        public decimal TempoInvestido;
        public decimal ValorLucro;
        public decimal PercentualLucro;

        public void CalculaInvestimento()
        {
            CalculaInvestimento(DinheiroAplicado, TaxaJuros, TempoInvestido);
        }

        private void CalculaInvestimento(decimal dinheroAplicado, decimal taxaJuros, decimal tempoInvestido)
        {
            ValorLucro = (dinheroAplicado * (taxaJuros / 100m)) * tempoInvestido;
            PercentualLucro = (ValorLucro / dinheroAplicado) * 100m;
        }

    }



}