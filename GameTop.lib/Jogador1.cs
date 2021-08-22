using System;
using GameTop.Interface;

namespace GameTop.libdo
{
    public class Jogador1 : Ijogador
    {
        string nome;
        public Jogador1(String nome)
        {
            this.nome = nome;
        }



        public string Chutar()
        {
            return $"{nome} chutou \n";
        }

        public string Correr()
        {
            return $"{nome} Correu \n";

        }

        public string Passe()
        {
            return $"{nome} chutou \n";

        }
    }
}