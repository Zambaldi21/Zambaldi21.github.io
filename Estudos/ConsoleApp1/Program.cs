using ConsoleApp1.Estudos;
using ConsoleApp1.Estudos.Conversao;
using ConsoleApp1.Estudos.Media;

namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main()
        {
            var opcao = "";
            while (opcao != "X")
            {
                opcao = ExibirMenu();
                Processar(opcao);

                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();

                Console.Clear();

            }; Console.WriteLine("Foi bom ter você aqui, volte sempre. Adeus!");
        }

        private static void Processar(string opcao)
        {
            switch (opcao)
            {
                case "0":
                    BrincandoComArrays.Processar();
                    break;
                case "1":
                    CalculaValorD.Processar();
                    break;
                case "2":
                    MaiorValor.Processar();
                    break;
                case "3":
                    CategoriaDeNadadores.Processar();
                    break;
                case "4":
                    IdadeEmDias.Processar();
                    break;
                case "5":
                    ConversaoHora.Processar();
                    break;
                case "6":
                    PesoIdeal.Processar();
                    break;
                case "7":
                    Multiplo.Processar();
                    break;
                case "8":
                    ConversaoIdade.Processar();
                    break;
                case "9":
                    MediaDeAprovacao.Processar();
                    break;
                case "10":
                    SistemasDeEquaçõesLineares.Processar();
                    break;
                case "11":
                    TrocoFacil.Processar();
                    break;
                case "12":
                    EquacaoDoSegundoGrau.Processar();
                    break;
                case "13":
                    Calculadora.Processar();
                    break;
                case "14":
                    DistanciaEntrePontos.Processar();
                    break;
                case "15":
                    Triangulo.Processar();
                    break;
                case "16":
                    Carro.Processar();
                    break;
                case "17":
                    Medias.Processar();
                    break;
                case "18":
                    MediaPeso.Processar();
                    break;
                case "19":
                    CaixaEletronico.Processar();
                    break;
                case "20":
                    HorasJogo.Processar();
                    break;
                case "21":
                    InteiroOuDecimal.Processar();
                    break;
                case "22":
                    SaldoMedio.Processar();
                    break;
                case "23":
                    AumentoSalario.Processar();
                    break;
                case "24":
                    ConceitoMedia.Processar();
                    break;
                case "25":
                    NumerosEleitores.Processar();
                    break;
                case "26":
                    CarrosVendidos.Processar();
                    break;
                case "27":
                    Fruteira.Processar();
                    break;
                case "28":
                    ValorCombustivel.Processar();
                    break;
                case "29":
                    CalculaIdade.Processar();
                    break;
                case "30":
                    Aposentadoria.Processar();
                    break;
                case "31":
                    Investimento.Processar();
                    break;
                case "32":
                    Bissexto.Processar();
                    break;
                case "X":
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        private static string ExibirMenu()
        {
            Console.WriteLine("Olá meu querido!");
            Console.WriteLine("Seja bem vindo ao melhor programa do mundo!");
            Console.WriteLine("Esses são os programas disponíveis.");
            Console.WriteLine("0 - Programa Favorito");
            Console.WriteLine("1 - CalculaValorD");
            Console.WriteLine("2 - MaiorValor");
            Console.WriteLine("3 - CategoriaDeNadadores");
            Console.WriteLine("4 - IdadeEmDias");
            Console.WriteLine("5 - ConversaoHora");
            Console.WriteLine("6 - PesoIdeal");
            Console.WriteLine("7 - Multiplo");
            Console.WriteLine("8 - ConversaoIdade");
            Console.WriteLine("9 - MediaDeAprovacao");
            Console.WriteLine("10 - SistemasDeEquaçõesLineares");
            Console.WriteLine("11 - TrocoFacil");
            Console.WriteLine("12 - EquacaoDoSegundoGrau");
            Console.WriteLine("13 - Calculadora");
            Console.WriteLine("14 - DistanciaEntrePontos");
            Console.WriteLine("15 - Triangulo");
            Console.WriteLine("16 - Carro");
            Console.WriteLine("16 - Medias");
            Console.WriteLine("18 - MediaPeso");
            Console.WriteLine("19 - CaixaEletrônico");
            Console.WriteLine("20 - HorasJogo");
            Console.WriteLine("21 - InteiroOuDecimal");
            Console.WriteLine("22 - SaldoMedio");
            Console.WriteLine("23 - AumentoSalário");
            Console.WriteLine("24 - ConceitoMedia");
            Console.WriteLine("25 - NumerosEleitores");
            Console.WriteLine("26 - CarrosVendidos");
            Console.WriteLine("27 - Fruteira");
            Console.WriteLine("28 - ValorCombustivel");
            Console.WriteLine("29 - CalculaIdade");
            Console.WriteLine("30 - Aposentadoria");
            Console.WriteLine("31 - Investimento");
            Console.WriteLine("32 - Bissexto");
            Console.WriteLine("X - Sair do programa");
            Console.WriteLine();
            Console.WriteLine("Qual programa deseja processar?");
            var opcao = Console.ReadLine();
            Console.Clear();
            return opcao.ToUpper();
        }
    }
}