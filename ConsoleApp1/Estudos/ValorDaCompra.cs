using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class ValorDaCompra
    {

        public static void Processar()
        {
            /* TO DO
             Colocar a diferença entre letras maiusculas e minusculas
           
             Exercício 21
             21. Um vendedor precisa de um algoritmo que calcule o preço total devido por um cliente. 
             O algoritmo deve receber o código de um produto e a quantidade comprada e calcular o preço total, 
             usando a tabela abaixo. Mostre uma mensagem no caso de código inválido.
             Código	Preço unitário
             'ABCD'	R$ 5,30
             'XYPK'	R$ 6,00
             'KLMP'	R$ 3,20
             'QRST'	R$ 2,50
            */

            var dadosIo = new DadosIo();

            //INPUT
            Console.WriteLine("Código Preço unitário\n ABCD R$5,30\n XYPK R$6,00\n KLMP R$3,20\n QRST R$2,50");
            var codigo = dadosIo.SolicitarStringAoUsuario("Digite o código do produto: ");

            //PROCESS
            var verificaCod = verificaCodigo(codigo);
            var quantidade = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de produtos: ", 0);
            var calcularValor = calculaValor(quantidade, codigo);

            //OUTPUT
            Console.WriteLine("O valor é " + calcularValor + " reais.");

        }
        private static string verificaCodigo(string codigo)
        {
            codigo = codigo.ToLower();
            while (codigo != "abcd" & codigo != "xypk" & codigo != "klmp" & codigo != "qrst")
            {
                Console.Write("O código inserido é inválido. Digite novamente um código válido: ");
                codigo = Console.ReadLine();
            }
            return codigo;
        }

        private static decimal calculaValor(int quantidade, string codigo)
        {
            // utilizar a funcao verificaCodigo!

            decimal valor = 0;
            if (verificaCodigo(codigo) == "abcd")
            {
                decimal valorAbcd = 5.3m * quantidade;
                valor = valorAbcd;
            }
            else if (codigo == "xypk")
            {
                decimal valorXypk = 6.0m * quantidade;
                valor = valorXypk;
            }
            else if (codigo == "klmp")
            {
                decimal valorKlmp = 3.2m * quantidade;
                valor = valorKlmp;
            }
            else //if (codigo == "qrst") - Descobrir pq está passando direto no codigo xypk
            {
                decimal valorQrst = 2.5m * quantidade;
                valor = valorQrst * 0;
            }

            return valor;
        }
    }
}
