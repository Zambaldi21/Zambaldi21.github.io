namespace ConsoleApp1.Estudos.Media
{
    public class Medias
    {
        public static void Processar()
        {
            var opcao = "";
            opcao = TipoDeCalculo();

            Console.WriteLine("Digita primeira nota.");
            var n1 = Console.ReadLine();
            Console.WriteLine("Digita segunda nota.");
            var n2 = Console.ReadLine();
            Console.WriteLine("Digita terceira nota.");
            var n3 = Console.ReadLine();


        }

        private static string TipoDeCalculo()
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("Média aritimética");
            Console.WriteLine("Média ponderada");
            Console.WriteLine("Média harmônica");
            var opcao = Console.ReadLine();
            return opcao;
        }
    }
}