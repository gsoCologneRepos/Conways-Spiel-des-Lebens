using System;

namespace GoL
{
    public class Starter
    {
        //Diese Klasse startet das Spiel, generiert das Array und befüllt die Zellen
        public Cell[,] start(int groesse)
        {
            Cell[,] spielfeld = new Cell[groesse,groesse];
            return spielfeld;
        }
        public Cell[,] fill(Cell[,] spielfeld)
        {
            Random rnd = new Random();
            for(int i=0;i<spielfeld.GetLength(0);i++)
            {
                for(int j=0;j<spielfeld.GetLength(0);j++)
                {
                    if (rnd.Next(1, 101) > 90)
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

        public static void spielzug(Cell[,] spielfeld,Cell[,] spielfeldNeu,int xMaxs)
        {
            for (int x = 0; x < spielfeld.GetLength(0); x++)
            {
                for (int y = 0; y < spielfeld.GetLength(0); y++)
                {
                    //Oben Links
                    if (x == 0 && y == 0)
                    {
                        Logik.topLeftCorner(spielfeld,spielfeldNeu);
                    }
                    //Unten Rechts
                    else if (x == xMax && y == xMax)
                    {
                        Logik.botRightCorner(spielfeld,spielfeldNeu,x);
                    }
                    //Unten Links
                    else if (x == xMax && y == 0)
                    {
                        Logik.botLeftCorner(spielfeld,spielfeldNeu,x);
                    }
                    
                    // oben Rechts
                    else if (x == 0 && y == xMax) 
                    {
                        Logik.topRightCorner(spielfeld,spielfeldNeu,x);
                    }
                   
                    //linke Spalte
                    else if(x!=0 && y== 0 && x!=xMax)
                    {
                        Logik.leftColumn(spielfeld,spielfeldNeu,x,y);
                    }
                    
                    //rechte Spalte
                    else if (x != 0 && y == xMax)
                    {
                        Logik.rightColumn(spielfeld,spielfeldNeu,x,y);
                    }
                    
                    //oben
                    else if(x==0 && y!= 0)
                    {
                        Logik.topRow(spielfeld,spielfeldNeu,x,y);
                    }
                    
                    //unten
                    else if(x==xMax && y!= 0)
                    {
                        Logik.botRow(spielfeld,spielfeldNeu,x,y);
                    }

                    else
                    {
                        Logik.fullCircle(spielfeld,spielfeldNeu,x,y);
                    }
                }
        }
    }
}