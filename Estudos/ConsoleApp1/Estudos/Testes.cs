namespace ConsoleApp1.Estudos
{
    public class Testes
    {
        public static void Processar()
        {
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();
            jogador1.energia = 90;
            Console.WriteLine("Energia do jogador 1: {0}", jogador1.energia);
            Console.WriteLine("Energia do jogador 2: {0}", jogador2.energia);
        }
    }

    public class Jogador
    {
        public int energia = 100;
        public bool vivo = true;
    }

}