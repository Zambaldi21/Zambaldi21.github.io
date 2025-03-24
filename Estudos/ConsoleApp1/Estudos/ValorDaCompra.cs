using ConsoleApp1.Utils;
using System.Threading.Channels;

namespace ConsoleApp1.Estudos
{
    public class ValorDaCompra
    {

        public static void Processar()
        {
            /*Exercício 21
             21. Um vendedor precisa de um algoritmo que calcule o preço total devido por um cliente. 
             O algoritmo deve receber o código de um produto e a quantidade comprada e calcular o preço total, 
             usando a tabela abaixo. Mostre uma mensagem no caso de código inválido.
             Código	Preço unitário
             'ABCD'	R$ 5,30
             'XYPK'	R$ 6,00
             'KLMP'	R$ 3,20
             'QRST'	R$ 2,50*/

            var dadosIo = new DadosIo();
            Console.WriteLine("Código Preço unitário\n ABCD R$5,30\n XYPK R$6,00\n KLMP R$3,20\n QRST R$2,50");

            var codigo = dadosIo.SolicitarStringAoUsuario("Digite o código do produto: ");
            //var verificaCod = 0;
            var quantidade = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de produtos: ", 0);
            var calcularValor = quantidade * 10;

            Console.WriteLine(calcularValor);

        }
    }
}
