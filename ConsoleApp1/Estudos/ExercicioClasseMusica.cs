namespace ConsoleApp1.Estudos
{
    public class ExercicioClasseMusica
    {
        public static void Processar()
        {
            Musica musica1 = new Musica();
            musica1.nome = "Roxane";
            musica1.artista = "The Police";
            musica1.duracao = 273;
            musica1.EscreveDisponivel(true);


            Musica musica2 = new Musica();
            musica2.nome = "Vertigo";
            musica2.artista = "U2";
            musica2.duracao = 367;
            musica1.EscreveDisponivel(false);

            musica1.ExibirFichaTecnica($"O nome da música é {musica1.nome}.");
            musica1.ExibirFichaTecnica($"O nome da música é {musica1.artista}.");
            musica1.ExibirFichaTecnica($"A duração da é {musica1.duracao}.");
            musica1.ExibirFichaTecnica($"{musica1.LeDisponivel}.");
            Console.WriteLine();
            musica1.ExibirFichaTecnica($"O nome da música é {musica2.nome}.");
            musica2.ExibirFichaTecnica($"O nome do artista é {musica2.artista}.");
            musica2.ExibirFichaTecnica($"O a duração da música é {musica2.duracao}.");
            musica2.ExibirFichaTecnica($"{musica2.LeDisponivel}.");




        }
    }
}