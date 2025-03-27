using ConsoleApp1.Utils;

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
            var verificaCod = verificaCodigo(codigo);
            var quantidade = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de produtos: ", 0);
            var calcularValor = quantidade * 5.3;

            //Colocar a diferença entre letras maiusculas e minusculas

            Console.WriteLine("O valor é " + calcularValor + " reais.");

        }
        private static string verificaCodigo(string codigo)
        {
            while (codigo != "abcd" & codigo != "xypk" & codigo != "klmp" & codigo != "qrst")
            {
                Console.WriteLine("O código inserido não existe. Digite novamente um código válido");
                codigo = Console.ReadLine();
            }
            return codigo;
        }
    }
}
