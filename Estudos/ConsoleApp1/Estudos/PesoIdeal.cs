namespace ConsoleApp1.Estudos
{
    public class PesoIdeal
    {
        public static void Processar()
        {
            var opcao = Genero();
            Processar2(opcao);
        }

        private static void Processar2(string opcao)
        {
            Console.WriteLine("Digite sua altura em metros, siga o exemplo: 1,71");
            var altura = Convert.ToDecimal(Console.ReadLine());

            switch (opcao)
            {
                case "M":
                    var calculoMasculino = ((72.7M * altura) - 58M);
                    Console.WriteLine($"O seu peso ideal é {calculoMasculino.ToString("F")}");
                    break;
                case "F":
                    var calculoFeminino = ((62.1M * altura) - 44.7M);
                    Math.Round(calculoFeminino, 2);
                    Console.WriteLine($"O seu peso ideal é {Math.Round(calculoFeminino, 2)}");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private static string Genero()
        {
            Console.WriteLine("Diga o seu gênero");
            Console.WriteLine("Digite M para masculino ou F para Feminino.");
            var opcao = Console.ReadLine();
            return opcao;
        }
    }
}