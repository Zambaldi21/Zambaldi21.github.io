using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class ControleDeProdutos
    {
        public static void Processar()
        {
            //Declara objetos
            var dadosIo = new DadosIo();
            var produtos = new Produtos();

            //Input
            produtos.KitMotorista = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de kits entregues aos motoristas: ");
            produtos.PaoMotorista = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de pães entregues aos motoristas: ");
            produtos.CafeMotorista = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de cafés entregues aos motoristas: ");
            produtos.AguaMotorista = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de águas entregues aos motoristas: ");
            produtos.KitTrabalhadores = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de kits entregues aos trabalhadores: ");
            produtos.PaoTrabalhadores = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de pães entregues aos trabalhadores: ");
            produtos.CafeTrabalhadores = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de cafés entregues aos trabalhadores: ");
            produtos.AguaTrabalhadores = dadosIo.SolicitarValorInteiroAoUsuario("Digite a quantidade de águas entregues aos trabalhadores: ");

            //process
            var resultadoCafeMoto = produtos.CalcularMotorista(produtos.KitMotorista, produtos.CafeMotorista);
            var resultadoPaoMoto = produtos.CalcularMotorista(produtos.KitMotorista, produtos.PaoMotorista);
            var resultadoAguaMoto = produtos.CalcularMotorista(produtos.KitMotorista, produtos.AguaMotorista);
            var resultadoCafeTrabalhador = produtos.CalcularMotorista(produtos.KitTrabalhadores, produtos.CafeTrabalhadores);
            var resultadoPaoTrabalhador = produtos.CalcularMotorista(produtos.KitTrabalhadores, produtos.PaoTrabalhadores);
            var resultadoAguaTrabalhador = produtos.CalcularMotorista(produtos.KitTrabalhadores, produtos.AguaTrabalhadores);

            //Output
            Console.Clear();
            Console.WriteLine($"Foram {resultadoCafeMoto} cafés para os motoristas.");
            Console.WriteLine($"Foram {resultadoPaoMoto} pães para os motoristas.");
            Console.WriteLine($"Foram {resultadoAguaMoto} águas para os motoristas.");
            Console.WriteLine($"Foram {resultadoCafeTrabalhador} cafés para os trabalhadores.");
            Console.WriteLine($"Foram {resultadoPaoTrabalhador} pães para os trabalhadores.");
            Console.WriteLine($"Foram {resultadoAguaTrabalhador} águas para os trabalhadores.");
            Console.WriteLine($"Total de cafés foi de {resultadoCafeTrabalhador + resultadoCafeMoto}");
            Console.WriteLine($"Total de pães foi de {resultadoPaoMoto + resultadoPaoTrabalhador}");
            Console.WriteLine($"Total de águas foi de {resultadoAguaTrabalhador + resultadoAguaMoto}");
        }
    }

    public class Produtos
    {
        public long KitMotorista { get; set; }
        public long PaoMotorista { get; set; }
        public long CafeMotorista { get; set; }
        public long AguaMotorista { get; set; }
        public long KitTrabalhadores { get; set; }
        public long PaoTrabalhadores { get; set; }
        public long CafeTrabalhadores { get; set; }
        public long AguaTrabalhadores { get; set; }
        public long Resultado { get; set; }

        public long CalcularMotorista(long valor1, long valor2)
        {
            Resultado = valor1 + valor2;
            return Resultado;
        }


    }
}
