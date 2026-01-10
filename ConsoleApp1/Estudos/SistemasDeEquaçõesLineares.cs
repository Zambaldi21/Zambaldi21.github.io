namespace ConsoleApp1.Estudos
{
    public class SistemasDeEquaçõesLineares
    {
        public static void Processar()
        {
            Console.Write("Digite o valor de A: ");
            var valorA = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            var valorB = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            var valorC = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o valor de D: ");
            var valorD = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o valor de E: ");
            var valorE = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o valor de F: ");
            var valorF = Convert.ToDecimal(Console.ReadLine());


            var calculoX = ((valorC * valorE) - (valorB * valorF)) / ((valorA * valorE) - (valorB * valorD));
            var calculoY = ((valorC * valorD) - (valorA * valorF)) / ((valorA * valorE) - (valorB * valorD));

            Console.WriteLine();
            Console.WriteLine($"O valor de X é {Math.Round(calculoX, 2)}");
            Console.WriteLine($"O valor de Y é {Math.Round(calculoY, 2)}");
        }
    }
}