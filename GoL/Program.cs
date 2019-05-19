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
            
            Console.WriteLine("Wie gross ist die Wahrscheinlichkeit, dass eine tote Zelle erschaffen wird?");
            int percent = Int32.Parse(Console.ReadLine());
            if (percent > 100)
            {
                Console.WriteLine("Wahrscheinlichkeit zu hoch! Starte neu!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
            
            Starter starter = new Starter();
            Cell[,] spielfeld = starter.start(xMax);
            Cell[,] pivot = starter.start(xMax);
            
            spielfeld = starter.fill(spielfeld,percent);
            
            int round = 1;
            while (true)
            {
                Zeichner.Zeichnen(spielfeld,round);
                Console.WriteLine("Es leben "+Logik.countAlive(spielfeld)+" Zellen.");
                pivot = spielfeld;
                spielfeld = Starter.spielzug(spielfeld, xMax,percent);
                round++;
                Thread.Sleep(1000);
                if (Logik.checkIfDone(spielfeld, pivot))
                {
                    Console.WriteLine("Spiel beendet.");
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }
    }
}