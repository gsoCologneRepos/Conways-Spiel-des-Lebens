using GoL.Input;
using GoL.Import;
using System;
using System.Threading;

namespace GoL
{
    class Program
    {
        static void Main()
        {
            int xMax;
            int percent;
            Starter starter = new Starter();
            Cell[,] spielfeld;
            Cell[,] pivot;

            Console.WriteLine("Wie wollen sie das Spielfeld definieren?");
            Console.WriteLine("1: Als Text importieren");
            Console.WriteLine("2: Manuell eingeben");
            bool choice = Console.ReadKey().Key.Equals("1");
            Console.Clear();

            if (choice)
            {
                Cell[,] textSpielfeld = ImportData.Txt();

                xMax = textSpielfeld.GetLength(0);

                spielfeld = starter.start(xMax);
                pivot = starter.start(xMax);
            }
            else
            {
                xMax = InputHandler.Number("Wie groß soll das Spielfeld sein?");
                percent = InputHandler.Number("Wie gross ist die Wahrscheinlichkeit, dass eine tote Zelle erschaffen wird?");

                if (percent > 100)
                {
                    Console.WriteLine("Wahrscheinlichkeit zu hoch! Starte neu!");
                    Console.ReadKey();
                    Environment.Exit(0x0);
                }

                spielfeld = starter.start(xMax);
                pivot = starter.start(xMax);

                spielfeld = starter.fill(spielfeld, percent);
            }
            
            int round = 1;
            while (true)
            {
                Console.Clear();
                Zeichner.Zeichnen(spielfeld, round);
                Console.WriteLine("Es leben " + Logik.countAlive(spielfeld) + " Zellen.");

                pivot = spielfeld;
                spielfeld = Starter.spielzug(spielfeld, xMax, percent);
                round++;

                if (Logik.checkIfDone(spielfeld, pivot))
                {
                    Console.WriteLine("Spiel beendet.");
                    Console.ReadKey();
                    Environment.Exit(0x0);
                }
            }
        }
    }
}