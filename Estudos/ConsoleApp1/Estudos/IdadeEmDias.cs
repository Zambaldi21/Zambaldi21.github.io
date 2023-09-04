using System.Security.Cryptography;

namespace ConsoleApp1.Estudos
{
    public class IdadeEmDias
    {
        public static void Processar()
        {
            var idadeUsario = new IdadeUsuario();

            idadeUsario.IdadeUsuarioAno = DigitarIdade("Digite a sua idade em anos");

            idadeUsario.IdadeUsuarioMes = DigitarIdade("Digite a sua idade em meses que ainda não completaram um ano");
            while ((idadeUsario.IdadeUsuarioMes > 11) ||(idadeUsario.IdadeUsuarioMes < 0))
            {
                Console.WriteLine("Não são aceitos no campo mês maior que 11 ou menor que 0. Por favor, digite novamente.");
                idadeUsario.IdadeUsuarioMes =  Convert.ToInt32(Console.ReadLine());
            }

            idadeUsario.IdadeUsuarioDia = DigitarIdade("Digite a sua idade em dias que ainda não completaram um mês");
            while ((idadeUsario.IdadeUsuarioDia > 30) ||(idadeUsario.IdadeUsuarioDia < 0))
            {
                Console.WriteLine("Não são aceitos no campo mês maior que 30 ou menor que 0. Por favor, digite novamente.");
                idadeUsario.IdadeUsuarioDia =  Convert.ToInt32(Console.ReadLine());
            }

            var idadeEmDias = idadeUsario.CalculaIdade(idadeUsario.IdadeUsuarioAno, idadeUsario.IdadeUsuarioMes, idadeUsario.IdadeUsuarioDia);
            Console.WriteLine($"O total dos seus dias de vida são {idadeEmDias}.");
        }

        public static int DigitarIdade(string descricao)
        {
            Console.WriteLine(descricao);
            var idade = Convert.ToInt32(Console.ReadLine());
            return idade;
        }

    }
    public class IdadeUsuario
    {
        public int IdadeUsuarioAno;
        public int IdadeUsuarioMes;
        public int IdadeUsuarioDia;

        public int CalculaIdade(int ano, int mes, int dia)
        {
            ano = Convert.ToInt32(ano * 365);
            mes = Convert.ToInt32(mes * 30);
            var idadeEmDias = Convert.ToInt32(dia + ano + mes);
            return idadeEmDias;
        }
    }



}