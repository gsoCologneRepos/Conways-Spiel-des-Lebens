using System;
using System.IO;

namespace GoL
{
    class Program
    {
        static void Main(string[] args)
        {
            Starter starter = new Starter();
            Cell[,] spielfeld = starter.start(5);

            spielfeld = starter.fill(spielfeld);
            spielfeld[0, 0].Status = true;
            spielfeld[0,1].Status = true;
            
            Zeichner.Zeichnen(spielfeld);
        }
    }
}