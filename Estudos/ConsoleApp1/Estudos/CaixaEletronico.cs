using ConsoleApp1.Utils;

namespace ConsoleApp1.Estudos
{
    public class CaixaEletronico
    {
        public static void Processar()
        {
            // Arrange, Act, Assert
            // Input, Process, Output

            //Input
            var dadosIo = new DadosIo();
            Console.WriteLine("As cédulas disponíveis para saque são de R$ 100,00; R$ 50,00; R$ 20,00; R$10,00.");
            var valorDesejado = dadosIo.SolicitarValorInteiroAoUsuario("Digite quanto deseja sacar: ", 0);

            //Process
            var banco = new Banco();
            var cedulas = banco.Sacar(valorDesejado);

            //Output
            foreach (var cedula in cedulas)
                Console.WriteLine($"Pegue uma cédula de {cedula}.");
        }
    }

    public class Banco
    {
        private long ValorDoSaque { get; set; }

        public List<long> Sacar(long valorDoSaque)
        {
            ValorDoSaque = valorDoSaque;

            var listaCedulas = new List<long>();

            listaCedulas.AddRange(EntregarCedulasEspecializado(100));
            listaCedulas.AddRange(EntregarCedulasEspecializado(50));
            listaCedulas.AddRange(EntregarCedulasEspecializado(20));
            listaCedulas.AddRange(EntregarCedulasEspecializado(10));
            listaCedulas.AddRange(EntregarCedulasEspecializado(5));
            listaCedulas.AddRange(EntregarCedulasEspecializado(2));
            listaCedulas.AddRange(EntregarCedulasEspecializado(1));

            return listaCedulas;
        }

        private List<long> EntregarCedulasEspecializado(long cedula)
        {
            var listaCedulas = new List<long>();

            while (ValorDoSaque >= cedula)
            {
                listaCedulas.Add(cedula);
                ValorDoSaque -= cedula;
            }
            return listaCedulas;
        }
    }
}