namespace ConsoleApp1.Estudos
{
    public class Triangulo
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o valor do lado A.");
            var ladoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado B.");
            var ladoB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado C.");
            var ladoC = Convert.ToDouble(Console.ReadLine());

            var maiorLado = ladoA;
            var menorLado = ladoB;
            var ladoMedio = ladoC;

            if (ladoB > maiorLado)
            {
                maiorLado = ladoB;
            }
            if (ladoC > maiorLado)
            {
                maiorLado = ladoC;
            }
            if (ladoC < menorLado)
            {
                menorLado = ladoC;
            }
            if (ladoA < menorLado)
            {
                menorLado = ladoA;
            }
            if (ladoMedio > menorLado && ladoMedio < maiorLado)
            {
                var ladoMediaVerdade = ladoMedio;
            }



            //if (maiorLado < menorLado )

            // se somar 2 lados quaisquer, eles não podem ser menor do que o maior lado
           //var a = 1;
           //var b = 1;
           //var c = 1;

            // se c == maior
            //  a + b > c

            // se b == maior
            //  a + c > b

            // se a == maior
            //  b + c > a


        }
        //private static int CalcularAreaEscaleno(int altura, int @base)
        //{
        //}
        //private static int CalcularAreaIsosceles(int altura, int @base)
        //{
        //}
    }

}
