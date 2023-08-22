using System.Collections.Specialized;
using System.ComponentModel.Design;

namespace ConsoleApp1.Estudos
{
    public class Fruteira
    {
        public static void Processar()
        {
            var morango = ObterDados("Digite quantos kilos o cliente comprou de morango");
            var maca = ObterDados("Digite quantos kilos o cliente comprou de maçã");
            var valorMorango = CalcularValorMorango(morango);
            var valorMaca = CalcularValorMaca(maca);
            Console.WriteLine($"O valor total é de R${valorMorango + valorMaca} reais.");

        }

        private static decimal ObterDados(string descricao)
        {
            Console.WriteLine(descricao);
            return Convert.ToDecimal(Console.ReadLine());
        }

        private static decimal CalcularValorMorango(decimal fruta)
        {
            decimal valor = 0;
            if (fruta > 5 && fruta <= 8)
            {
                valor = Math.Round(fruta * 2.20m, 2);
            }
            else if ((fruta > 8) || (valor > 25))
            {
                valor = fruta * 2.20m;
                valor = Math.Round(valor - (valor * (0.1m)), 2);
            }
            else
            {
                valor = Math.Round(fruta * 2.50m, 2);
            }

            return valor;
        }

        private static decimal CalcularValorMaca(decimal fruta)
        {
            decimal valor = 0;
            if (fruta > 5 && fruta <= 8)
            {
                valor = Math.Round(fruta * 1.50m, 2);
            }
            else if ((fruta > 8) || (valor > 25))
            {
                valor = fruta * 1.50m;
                valor = Math.Round(valor - (valor * (0.1m)), 2);
            }
            else
            {
                valor = Math.Round(fruta * 1.80m, 2);
            }

            return valor;
        }



    }
}