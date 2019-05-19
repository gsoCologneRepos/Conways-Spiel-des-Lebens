using System.Runtime.Serialization;

namespace GoL
{
    public static class Logik
    {
        public static int checkTop(Cell[,] spielfeld, int x, int y)
        {
            if (spielfeld[x-1, y].Status)
            {
                return 1;
            }

            return 0;
        }

        public static int checkTopLeft(Cell[,] spielfeld, int x, int y)
        {
            if (spielfeld[x - 1, y - 1].Status)
            {
                return 1;
            }

            return 0;
        }

        public static int checkLeft(Cell[,] spielfeld, int x, int y)
        {
            if (spielfeld[x, y - 1].Status)
            {
                return 1;
            }

            return 0;
        }
        
        public static int checkBotLeft(Cell[,] spielfeld, int x, int y)
        {
            if (spielfeld[x + 1, y - 1].Status)
            {
                return 1;
            }

            return 0;
        }


        public static int checkBot(Cell[,] spielfeld, int x, int y)
        {
            if (spielfeld[x+1, y].Status)
            {
                return 1;
            }

            return 0;
        }
        
        public static int checkBotRight(Cell[,] spielfeld, int x, int y)
        {
            if (spielfeld[x+1, y + 1].Status)
            {
                return 1;
            }

            return 0;
        }
        
        public static int checkRight(Cell[,] spielfeld, int x, int y)
        {
            if (spielfeld[x, y + 1].Status)
            {
                return 1;
            }
            return 0;
        }

        public static int checkTopRight(Cell[,] spielfeld, int x, int y)
        {
            if (spielfeld[x-1,y+1].Status)
            {
                return 1;
            }

            return 0;
        }
        
        
        public static void topLeftCorner(Cell[,] spielfeld, Cell[,] spielfeldNeu)
        {
            int counter = 0;
            counter += checkRight(spielfeld, 0, 0);
            counter += checkBotRight(spielfeld, 0, 0);
            counter += checkBot(spielfeld, 0, 0);

            if (counter >= 3)
            {
                spielfeldNeu[0, 0].Status = true;
            }
        }
        

        public static void botLeftCorner(Cell[,] spielfeld, Cell[,] spielfeldNeu, int x)
        {
            int counter = 0;
        }

        //[Zeile,Spalte]
        public static void topRightCorner(Cell[,] spielfeld, Cell[,] spielfeldNeu, int x)
        {
            if (spielfeld[0, x - 1].Status == true && spielfeld[1, x].Status == true &&
                spielfeld[1, x - 1].Status == true)
            {
                spielfeldNeu[0, x].Status = true;
            }
            else
            {
                spielfeldNeu[0, x].Status = false;
            }
        }

        public static void botRightCorner(Cell[,] spielfeld, Cell[,] spielfeldNeu, int x)
        {
            if (spielfeld[x - 1, x - 1].Status == true && spielfeld[x, x - 1].Status == true &&
                spielfeld[x - 1, x].Status == true)
            {
                spielfeldNeu[x, x].Status = true;
            }
            else
            {
                spielfeldNeu[x, x].Status = false;
            }
        }

        public static void topRow(Cell[,] spielfeld, Cell[,] spielfeldNeu, int i)
        {
            int counter = 0;
            if (spielfeld[0, i - 1].Status == true)
            {
                counter++;
            }

            if (spielfeld[1, i - 1].Status == true)
            {
                counter++;
            }

            if (spielfeld[1, i].Status == true)
            {
                counter++;
            }

            if (spielfeld[1, i + 1].Status == true)
            {
                counter++;
            }

            if (spielfeld[0, i + 1].Status == true)
            {
                counter++;
            }

            if (counter >= 3)
            {
                spielfeldNeu[0, i].Status = true;
            }
        }
    }
}