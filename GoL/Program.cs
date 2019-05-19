using System;
using System.IO;
using System.Net;
using System.Threading;

namespace GoL
{
    class Program
    {
        static void Main(string[] args)
        {
            Starter starter = new Starter();
            int xMax = 5;

            Cell[,] spielfeld = starter.start(xMax);
           

            spielfeld = starter.fill(spielfeld);
            int round = 1;
            int counter = 0;
            while (true)
            {
                spielfeld = Starter.spielzug(spielfeld, xMax);
                Zeichner.Zeichnen(spielfeld,round);
                round++;
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}