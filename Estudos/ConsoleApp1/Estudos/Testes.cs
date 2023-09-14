namespace ConsoleApp1.Estudos
{
    public class Testes
    {
        public static void Processar()
        {
            Console.WriteLine("Digite o nome do jogador 1.");
            string nome = Console.ReadLine();
            //Console.WriteLine("Digite o nome do jogador 2");
            //string nome1 = Console.ReadLine();

            Jogador jogador1 = new Jogador(nome);
            Jogador jogador2 = new Jogador("Jorge");

            Console.WriteLine($"Nome do jogador 1 é {jogador1.Nome} e a energia do jogador é {jogador1.Energia}");
            Console.WriteLine("Nome do jogador 2: {0}", jogador2.Nome);
        }
    }

    public class Jogador
    {
        public int Energia;
        public bool Vivo;
        public string Nome;
        public Jogador(string nome)
        {
            Energia = 100;
            Vivo = true;
            Nome = nome;
        }
        ~Jogador()
        {
            Console.WriteLine($"Jogador {Nome} foi destruído!");
        }
    }

}