using System.ComponentModel.Design;

namespace ConsoleApp1.Estudos
{
    public class Bissexto
    {
        public static void Processar()
        {
            var anoBissexto = new AnoBissexto();


            anoBissexto.Ano = DigitarAno("Digite o ano que deseja saber se é bissexto ou não.");


            var mensagem = anoBissexto.EhBissexto ? $"O ano {anoBissexto.Ano} é um ano bissexto" : $"O ano {anoBissexto.Ano} não é um ano bissexto";

            Console.WriteLine(mensagem);
        }

        public static int DigitarAno(string descricao)
        {
            Console.WriteLine(descricao);
            var ano = Convert.ToInt32(Console.ReadLine());
            return ano;
        }
    }

    // Diga se um ano escrito pelo usuário é bissexto ou não.

    public class AnoBissexto
    {
        public int Ano { get; set; }

        public bool EhBissexto => EhDivisivelPor400 || (EhDivisivelPor4 && !EhDivisivelPor100);

        private bool EhDivisivelPor4 => (Ano % 4 == 0);
        private bool EhDivisivelPor100 => (Ano % 100 == 0);
        private bool EhDivisivelPor400 => (Ano % 400 == 0);


    }
}