using System;
using System.Threading;

namespace GoL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie gross soll das Spielfeld sein?");
            int xMax = Int32.Parse(Console.ReadLine());
            Starter starter = new Starter();

            Cell[,] spielfeld = starter.start(xMax);
           

            spielfeld = starter.fill(spielfeld);
            int round = 1;
            int counter = 0;
            
            while (true)
            {
                Zeichner.Zeichnen(spielfeld,round);
                spielfeld = Starter.spielzug(spielfeld, xMax);
                round++;
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}