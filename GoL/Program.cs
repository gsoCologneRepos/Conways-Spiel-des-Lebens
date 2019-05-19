using System;
using System.IO;
using System.Net;

namespace GoL
{
    class Program
    {
        static void Main(string[] args)
        {
            Starter starter = new Starter();
            int xMax = 5;

            Cell[,] spielfeld = starter.start(xMax);
            Cell[,] spielfeldNeu = starter.start(xMax);

            spielfeld = starter.fill(spielfeld);
            spielfeldNeu = starter.fill(spielfeldNeu);
            int round = 1;
            int counter = 0;
            while (true)
            {
                Starter.spielzug(spielfeld, spielfeldNeu, xMax);
                Zeichner.Zeichnen(spielfeldNeu, round);
                
                for (int x = 0; x < spielfeld.GetLength(0); x++)
                {
                    for (int y = 0; y < spielfeld.GetLength(0); y++)
                    {
                        if (spielfeld[x, y].Status == spielfeldNeu[x, y].Status)
                        {
                            counter++;
                        }

                        if (counter == xMax * xMax)
                        {
                            Console.WriteLine("Spiel beendet.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        spielfeld[x, y].Status = spielfeldNeu[x, y].Status;
                    }
                }
            }
        }
    }
}