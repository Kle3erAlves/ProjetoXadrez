using System;
using Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4); //gera uma nova posicao no namespace Tabuleiro classe Posicao

            Console.WriteLine("Posicao: " + P);
            Console.ReadLine();

        }
    }
}
