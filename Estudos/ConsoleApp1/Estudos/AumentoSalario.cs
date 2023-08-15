using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace ConsoleApp1.Estudos
{
    public class AumentoSalario
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o seu nome.");
            var nome = Console.ReadLine();
            var cargo = obterCargo();
            Console.WriteLine("Digite seu salário.");
            var salario = Convert.ToDecimal(Console.ReadLine());
            var aumentoSalario = calculaAumento(cargo, salario);
            var novoSalario = salario + aumentoSalario;
            Console.WriteLine($"{nome}, o seu salário antigo é de {salario}, o seu novo salário é {novoSalario} e a diferença é de {aumentoSalario}.");
        }

        private static decimal obterCargo()
        {
            Console.WriteLine("Digite o código segundo o seu cargo.");
            Console.WriteLine("Gerente - 101 ");
            Console.WriteLine("Engenheiro - 102");
            Console.WriteLine("Técnico - 103");
            Console.WriteLine("Outro - 104");
            var cargo = Convert.ToDecimal(Console.ReadLine());
            return cargo;
        }

        private static decimal calculaAumento(decimal cargo, decimal salario)
        {
            decimal percentual;


            switch (cargo)
            {
                case 101:
                    percentual = 10m / 100m;
                    break;
                case 102:
                    percentual = 20m / 100m;
                    break;
                case 103:
                    percentual = 30m / 100m;
                    break;
                case 104:
                    percentual = 40m / 100m;
                    break;
                default:
                    percentual = 0;
                    break;
            }
            return percentual * salario;
        }
    }
}