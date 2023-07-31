namespace ConsoleApp1.Estudos
{
    public class PesoIdeal
    {
        const string homem = "H";

        public static void Processar()
        {
            Console.WriteLine("Digite H para homem e M para mulher.");
            var genero = Console.ReadLine();
            Console.WriteLine("Digite sua altura em metros, siga o exemplo: 1,71");
            var altura = Convert.ToDecimal(Console.ReadLine());

            if (EhHomem(genero))
            {
                var calculoMasculino = ((72.7M * altura) - 58M);
                Console.WriteLine($"O seu peso ideal é {calculoMasculino.ToString("F")}");
            }
            else
            {
                var calculoFeminino = ((62.1M * altura) - 44.7M);
                //Math.Round(calculoFeminino, 2);
                Console.WriteLine($"O seu peso ideal é {Math.Round(calculoFeminino, 2)}");
            }
        }

        private static bool EhHomem(string genero)
        {
            return genero == homem;
        }
    }
}