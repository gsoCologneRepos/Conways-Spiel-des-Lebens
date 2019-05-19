using System;

namespace GoL
{
    public class Starter
    {
        //Diese Klasse startet das Spiel, generiert das Array und befüllt die Zellen
        public Cell[,] start(int groesse)
        {
            Cell[,] spielfeld = new Cell[groesse, groesse];
            return spielfeld;
        }

        public Cell[,] fill(Cell[,] spielfeld, int percent)
        {
            Random rnd = new Random();
            for (int i = 0; i < spielfeld.GetLength(0); i++)
            {
                for (int j = 0; j < spielfeld.GetLength(0); j++)
                {
                    if (rnd.Next(1, 101) > percent)
                    {
                        spielfeld[i, j] = new Cell(true);
                    }
                    else
                    {
                        spielfeld[i, j] = new Cell(false);
                    }
                }
            }

            return spielfeld;
        }

        public static Cell[,] spielzug(Cell[,] spielfeld, int xMax,int percent)
        {
            Starter starter = new Starter();
            Cell[,] spielfeldNeu = starter.start(xMax);
            spielfeldNeu = starter.fill(spielfeldNeu,percent);
            
            xMax = xMax - 1;
            for (int x = 0; x < spielfeld.GetLength(0); x++)
            {
                for (int y = 0; y < spielfeld.GetLength(0); y++)
                {
                    //Oben Links
                    if (x == 0 && y == 0)
                    {
                        spielfeldNeu[0,0].Status = Logik.topLeftCorner(spielfeld);
                    }
                    //Unten Rechts
                    else if (x == xMax && y == xMax)
                    {
                        spielfeldNeu[x,y].Status = Logik.botRightCorner(spielfeld, x);
                    }
                    //Unten Links
                    else if (x == xMax && y == 0)
                    {
                        spielfeldNeu[xMax,0].Status = Logik.botLeftCorner(spielfeld, x);
                    }

                    // oben Rechts
                    else if (x == 0 && y == xMax)
                    {
                        spielfeldNeu[0,xMax].Status = Logik.topRightCorner(spielfeld, y);
                    }

                    //linke Spalte
                    else if (x != 0 && y == 0 && x != xMax)
                    {
                        spielfeldNeu[x,y].Status = Logik.leftColumn(spielfeld, x, y);
                    }

                    //rechte Spalte
                    else if (x != 0 && y == xMax)
                    {
                        spielfeldNeu[x,y].Status = Logik.rightColumn(spielfeld, x, y);
                    }

                    //oben
                    else if (x == 0 && y != 0 && y!=xMax)
                    {
                        spielfeldNeu[x,y].Status = Logik.topRow(spielfeld, x, y);
                    }

                    //unten
                    else if (x == xMax && y != 0)
                    {
                        spielfeldNeu[x,y].Status =Logik.botRow(spielfeld, x, y);
                    }

                    else
                    {
                        spielfeldNeu[x,y].Status =Logik.fullCircle(spielfeld, x, y);
                    }
                }
            }

            return spielfeldNeu;
        }
    }
}