using System;
using GameTop.Interface;

namespace GameTop
{
    class JogoFoda
    {
        public readonly Ijogador jogadorA;
        public readonly Ijogador jogadorB;
        public JogoFoda(Ijogador jogadorA, Ijogador jogadorB)
        {
            this.jogadorA = jogadorA;
            this.jogadorB = jogadorB;

        }
        public void IniciarJogo()
        {
            System.Console.Write(jogadorA.Correr());
            System.Console.Write(jogadorA.Chutar());
            System.Console.Write(jogadorA.Passe());

            System.Console.Write(jogadorB.Correr());
            System.Console.Write(jogadorB.Chutar());
            System.Console.Write(jogadorB.Passe());

        }
    }

}
