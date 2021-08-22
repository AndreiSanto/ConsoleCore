using System;
using GameTop.lib;
using GameTop.libdo;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {

            var jogo = new JogoFoda(new Jogador1("Andrei"), new Jogador2());
            jogo.IniciarJogo();


        }
    }
    
       
}
