﻿using ConsoleApp1.Estudos;

namespace ConsoleApp1.Estudos
{
    class Musica
    {
        public string nome;
        public string artista;
        public int duracao;
        private bool disponivel;
        public void EscreveDisponivel(bool value)
        {
            disponivel = value;
        }
        public bool LeDisponivel()
        {
            return disponivel;
        }
        public void ExibirFichaTecnica(string descricao)
        {
            Console.WriteLine(descricao);
        }
    }
}
