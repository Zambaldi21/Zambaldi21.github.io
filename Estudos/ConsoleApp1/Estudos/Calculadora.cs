namespace ConsoleApp1.Estudos
{
    public class Calculadora
    {
        public static void Processar()
        {
            var operacao = "";
            operacao = Operação();
            Console.WriteLine("Digite o valor de A.");
            var valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B.");
            var valorB = Convert.ToDouble(Console.ReadLine());
            switch (operacao)
            {
                case "Soma":
                    var soma = valorA + valorB;
                    Console.WriteLine($"O resultado da soma é {soma}.");
                    break;
                case "Subtração":
                    var subtracao = valorA - valorB;
                    Console.WriteLine($"O resultado da subtração é {subtracao}.");
                    break;
                case "Multiplicação":
                    var multiplicacao = valorA * valorB;
                    Console.WriteLine($"O resultado da multiplicação é {multiplicacao}.");
                    break;
                case "Divisão":
                    var divisao = valorA / valorB;
                    Console.WriteLine($"O resultado da divisão é {divisao}");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        private static string Operação()
        {
            Console.WriteLine("Escolha uma operação.");
            Console.WriteLine("Soma, subtração, multiplicação e divisão.");
            var operacao = Console.ReadLine();
            return operacao;

        }
    }
}

