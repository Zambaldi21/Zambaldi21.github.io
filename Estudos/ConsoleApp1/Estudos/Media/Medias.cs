using ConsoleApp1.Utils;
using System.Reflection.Metadata;

namespace ConsoleApp1.Estudos.Media
{
    public class Medias
    {
        public static void Processar()
        {
            var valor = new DadosIo();
            var opcao = new CalculoMedias();

            var dado = opcao.TipoDeCalculo();

            opcao.Nota1 = valor.SolicitarValorDecimalAoUsuario("Digite a primeira nota", 0, 10);
            opcao.Nota2 = valor.SolicitarValorDecimalAoUsuario("Digite a segunda nota", 0, 10);
            opcao.Nota3 = valor.SolicitarValorDecimalAoUsuario("Digite a terceira nota", 0, 10);
            var resultado = opcao.Calcular(dado);

            Console.WriteLine($"A sua média é de {Math.Round(resultado, 2)}.");
        }
    }

    public class CalculoMedias
    {
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal NotaResultado { get; set; }

        public decimal TipoDeCalculo()
        {

            Console.WriteLine("Escolha uma opção por números");
            Console.WriteLine("1 - Média aritimética");
            Console.WriteLine("2 - Média ponderada");
            Console.WriteLine("3 - Média harmônica");
            Console.Write("Digite: ");
            var opcao = Convert.ToDecimal(Console.ReadLine());
            return opcao;
        }
        public decimal Calcular(decimal opcao)
        {
            switch (opcao)
            {
                case 1:
                    NotaResultado = (Nota1 + Nota2 + Nota3) / 3;
                    break;
                case 2:
                    NotaResultado = ((Nota1 * 3) + (Nota2 * 3) + (Nota3 * 4)) / 10;
                    break;
                case 3:
                    NotaResultado = 3 / ((1 / Nota1) + (1 / Nota2) + (1 / Nota3));
                    break;
            }
            return NotaResultado;

        }
    }



}