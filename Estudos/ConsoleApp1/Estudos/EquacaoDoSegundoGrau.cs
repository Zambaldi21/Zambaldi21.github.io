namespace ConsoleApp1.Estudos
{
    public class EquacaoDoSegundoGrau
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o valor de A.");
            var valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B.");
            var valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C.");
            var valorC = Convert.ToInt32(Console.ReadLine());


            Calculo(valorA, valorB, valorC);
        }

        private static void Calculo(double valorA, double valorB, double valorC)
        {
            var calculaDelta = Math.Pow(valorB, 2) + (-4 * valorA * valorC);
            var calculaRaiz = Math.Sqrt(calculaDelta);
            var calculaResultadoNegativo = Convert.ToDouble((-valorB - calculaRaiz) / (2 * valorA));
            var calculaResultadoPositivo = Convert.ToDouble((-valorB + calculaRaiz) / (2 * valorA));

            if (calculaDelta > 0)
            {
                Console.WriteLine($"O valor de X1 é {calculaResultadoPositivo}.");
                Console.WriteLine($"O valor de X2 é {calculaResultadoNegativo}.");

            }
            if (calculaDelta == 0)
            {
                Console.WriteLine("O valor de delta é igual a zero, sendo assim suas raízes são iguais.");
                Console.WriteLine($"O valor das raízes é igual a {calculaResultadoPositivo}.");
            }
            if (calculaDelta < 0)
            {
                Console.WriteLine("O valor de delta é menor que 0, sendo assim não é possível concluir a equação.");
            }
        }
    }
}