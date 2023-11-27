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
                Console.Clear();
                Console.WriteLine("Valor inválido. Digite novamente!");
                operacao.operacao = dadosIo.SolicitarStringAoUsuario(mensagem);
            }
            operacao.NumeroA = dadosIo.SolicitarValorDecimalAoUsuario(mensagemValorA);
            operacao.NumeroB = dadosIo.SolicitarValorDecimalAoUsuario(mensagemValorB);

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

            Console.WriteLine();
            Console.WriteLine("Você deseja adicionar outro número ou fazer uma nova operação?");
            operacao.operacao = dadosIo.SolicitarStringAoUsuario("Digite 0 para adicionar um novo número, digite 1 para fazer uma nova operação ou x para encerrar o programa: ").ToUpper();

            while (operacao.operacao != "0" && operacao.operacao != "1" && operacao.operacao != "x")
            {
                Console.Clear();
                Console.WriteLine("Opção inválida. Por favor, digite novamente.");
                operacao.operacao = dadosIo.SolicitarStringAoUsuario("Digite 0 para adicionar um novo número, digite 1 para fazer uma nova operação ou x para encerrar o programa: ");
            }

            Console.Clear();
            while (operacao.operacao == "0")
            {
                Console.WriteLine($"O resultado da operação anterior é {operacao.Resultado}");
                operacao.operacao = dadosIo.SolicitarStringAoUsuario(mensagem);
                operacao.NumeroAdicional = dadosIo.SolicitarValorDecimalAoUsuario("Digite o número adicional: ");
                operacao.Resultado = operacao.CalculoAdicional();
                if (operacao.operacao == "+")
                    Console.WriteLine($"O resultado dessa soma é {operacao.Resultado}");
                else if (operacao.operacao == "-")
                    Console.WriteLine($"O resultado dessa subtração é {operacao.Resultado}");
                else if (operacao.operacao == "*")
                    Console.WriteLine($"O resultado dessa multiplicação é {operacao.Resultado}");
                else
                    Console.WriteLine($"O resultado dessa divisão é {operacao.Resultado}");
            }
            while (operacao.operacao == "1")
            {
                operacao.operacao = dadosIo.SolicitarStringAoUsuario(mensagem);
                operacao.NumeroA = dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor de A: ");
                operacao.NumeroB = dadosIo.SolicitarValorDecimalAoUsuario("Digite o valor de B: ");
                operacao.Resultado = operacao.CalculoAdicional();
                if (operacao.operacao == "+")
                    Console.WriteLine($"O resultado dessa soma é {operacao.Resultado}");
                else if (operacao.operacao == "-")
                    Console.WriteLine($"O resultado dessa subtração é {operacao.Resultado}");
                else if (operacao.operacao == "*")
                    Console.WriteLine($"O resultado dessa multiplicação é {operacao.Resultado}");
                else
                    Console.WriteLine($"O resultado dessa divisão é {operacao.Resultado}");
            }
            if (operacao.operacao == "x")
            {
                Console.WriteLine("Bye bye!");
            }
        }
    }
    public class Operacao
    {
        public string operacao { get; set; }
        public decimal NumeroA { get; set; }
        public decimal NumeroB { get; set; }
        public decimal NumeroAdicional { get; set; }
        public decimal Resultado { get; set; }

        public decimal Calculo()
        {
            switch (operacao)
            {
                case "+":
                    Resultado = NumeroA + NumeroB;
                    break;
                case "-":
                    Resultado = NumeroA - NumeroB;
                    break;
                case "*":
                    Resultado = NumeroA * NumeroB;
                    break;
                case "/":
                    Resultado = NumeroA / NumeroB;
                    break;
                default:
                    break;
            }
            return Math.Round(Resultado, 2);
        }
        public decimal CalculoAdicional()
        {
            switch (operacao)
            {
                case "+":
                    Resultado = Resultado + NumeroAdicional;
                    break;
                case "-":
                    Resultado = Resultado - NumeroAdicional;
                    break;
                case "*":
                    Resultado = Resultado * NumeroAdicional;
                    break;
                case "/":
                    Resultado = Resultado / NumeroAdicional;
                    break;
                default:
                    break;
            }
            return Math.Round(Resultado, 2);
        }
    }
}

