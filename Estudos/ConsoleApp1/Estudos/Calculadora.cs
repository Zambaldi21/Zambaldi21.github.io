using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class Calculadora
    {
        const string mensagem = @"Digite a operação que deseja:
+ para soma
-  para subtração
* para multiplicação
/ para divisão: ";
        const string mensagemValorA = "Digite o valor de A: ";
        const string mensagemValorB = "Digite o valor de B: ";
        public static void Processar()
        {
            // Inputs
            var dadosIo = new DadosIo();
            var operacao = new Operacao();
            operacao.operacao = dadosIo.SolicitarStringAoUsuario(mensagem);
            while ((operacao.operacao != "+") && (operacao.operacao != "-") && (operacao.operacao != "*") && (operacao.operacao != "/"))
            {
                Console.WriteLine("Valor inválido. Digite novamente!");
                operacao.operacao = dadosIo.SolicitarStringAoUsuario(mensagem);
            }
            operacao.ValorA = dadosIo.SolicitarValorDecimalAoUsuario(mensagemValorA);
            operacao.ValorB = dadosIo.SolicitarValorDecimalAoUsuario(mensagemValorB);

            // Process
            operacao.Resultado = operacao.Calculo();

            // Outputs
            if (operacao.operacao == "+")
                Console.WriteLine($"O resultado dessa soma é {operacao.Resultado}");
            else if (operacao.operacao == "-")
                Console.WriteLine($"O resultado dessa subtração é {operacao.Resultado}");
            else if (operacao.operacao == "*")
                Console.WriteLine($"O resultado dessa multiplicação é {operacao.Resultado}");
            else
                Console.WriteLine($"O resultado dessa divisão é {operacao.Resultado}");
        }
    }
    public class Operacao
    {
        public string operacao { get; set; }
        public decimal ValorA { get; set; }
        public decimal ValorB { get; set; }
        public decimal Resultado { get; set; }

        public decimal Calculo()
        {
            switch (operacao)
            {
                case "+":
                    Resultado = ValorA + ValorB;
                    break;
                case "-":
                    Resultado = ValorA - ValorB;
                    break;
                case "*":
                    Resultado = ValorA * ValorB;
                    break;
                case "/":
                    Resultado = ValorA / ValorB;
                    break;
                default:
                    break;
            }
            return Math.Round(Resultado, 2);
        }
    }
}

