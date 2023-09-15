namespace ConsoleApp1.Estudos
{
    public class CalculaValorD
    {
        public static void Processar()
        {
            var valores = new Valores();

            valores.ValorA = valores.ObterValores("Digite o valor de A");
            valores.ValorB = valores.ObterValores("Digite o valor de B");
            valores.ValorC = valores.ObterValores("Digite o valor de C");

            var calculoValor = new CalculoValor();

            calculoValor.ValorD = calculoValor.CalculaD(valores.ValorA, valores.ValorB, valores.ValorC);

            Console.WriteLine();
            Console.WriteLine("O valor de D é: {0}", calculoValor.ValorD);




        }
    }
    public class CalculoValor
    {
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        public double ValorC { get; set; }
        public double ValorR { get; set; }
        public double ValorS { get; set; }
        public double ValorD { get; set; }
        public double DobroR { get; set; }
        public double DobroS { get; set; }

        public double CalculaD(decimal valorA, decimal valorB, decimal valorC)
        {
            ValorR = ValorA + ValorB;
            DobroR = Math.Pow(ValorR, 2);
            ValorS = ValorB + ValorC;
            var dobroDeS = Math.Pow(ValorS, 2);
            ValorD = (DobroR + dobroDeS) / 2;

            return ValorD;
        }
    }






}