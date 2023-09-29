using ConsoleApp1.Utils;
using System.ComponentModel.Design;

namespace ConsoleApp1.Estudos
{
    public class Bissexto
    {
        // Exercício: Diga se um ano escrito pelo usuário é bissexto ou não.
        public static void Processar()
        {
            // Intancia objetos
            var dadosIo = new DadosIo();
            var anoBissexto = new AnoBissexto();

            //Solicita dado ao usuário
            anoBissexto.Ano = dadosIo.SolicitarValorInteiroAoUsuario("Digite o ano que deseja saber se é bissexto ou não:", 0);

            // Mostra resultado
            var mensagem = anoBissexto.EhBissexto ? $"O ano {anoBissexto.Ano} é um ano bissexto" : $"O ano {anoBissexto.Ano} não é um ano bissexto";

            Console.WriteLine(mensagem);
        }
    }
    public class AnoBissexto
    {
        public long Ano { get; set; }

        public bool EhBissexto => EhDivisivelPor400 || (EhDivisivelPor4 && !EhDivisivelPor100);

        private bool EhDivisivelPor4 => (Ano % 4 == 0);
        private bool EhDivisivelPor100 => (Ano % 100 == 0);
        private bool EhDivisivelPor400 => (Ano % 400 == 0);
    }
}