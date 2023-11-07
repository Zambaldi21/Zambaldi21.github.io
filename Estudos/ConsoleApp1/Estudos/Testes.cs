

namespace ConsoleApp1.Estudos
{
    public class Testes
    {
        public static void Processar()
        {
            /*
            // Declara constantes
            const int mediaDeAprovacao = 8;

            // input
            Console.WriteLine($"Média de aprovação é {mediaDeAprovacao}.");
            Console.Write("Digite a sua 1° nota: ");
            var nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a sua 2° nota: ");
            var nota2 = Convert.ToDecimal(Console.ReadLine());

            // process
            var media = (nota1 + nota2) / 2;

            // output
            if (media > mediaDeAprovacao)
            {
                Console.WriteLine($"Parabéns, você foi aprovado. A sua média foi de {media}.");
            }
            else
            {
                Console.WriteLine($"Burro, você foi reproprovado. A sua média foi de {media}.");
            } */

            Console.Write("Digite o seu nome: ");
            var nome = Console.ReadLine();
            Console.Write("Digite o seu sobrenome: ");
            var sobrenome = Console.ReadLine();
            Console.WriteLine(sobrenome + " " + nome);
        }

        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}