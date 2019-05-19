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
            counter += checkTop(spielfeld, x, 0);
            counter += checkTopRight(spielfeld, x, 0);
            counter += checkRight(spielfeld, x, 0);
            
            if (counter >= 3)
            {
                spielfeldNeu[x, 0].Status = true;
            }
        }

        //[Zeile,Spalte]
        public static void topRightCorner(Cell[,] spielfeld, Cell[,] spielfeldNeu, int x)
        {
            int counter = 0;
            counter += checkLeft(spielfeld, 0, x);
            counter += checkBotLeft(spielfeld, 0, x);
            counter += checkBot(spielfeld, 0, x);

            if (counter >= 3)
            {
                spielfeldNeu[0, x].Status = true;
            }
        }

        public static void botRightCorner(Cell[,] spielfeld, Cell[,] spielfeldNeu, int x)
        {
            int counter = 0;
            counter += checkTop(spielfeld, x, x);
            counter += checkTopLeft(spielfeld, x, x);
            counter += checkLeft(spielfeld, x, x);
            
            if (counter >= 3)
            {
                spielfeldNeu[x, x].Status = true;
            }
        }

        public static void topRow(Cell[,] spielfeld, Cell[,] spielfeldNeu, int x,int y)
        {
            int counter = 0;
            counter += checkLeft(spielfeld, x, y);
            counter += checkBotLeft(spielfeld, x, y);
            counter += checkBot(spielfeld, x, y);
            counter += checkBotRight(spielfeld, x, y);
            counter += checkRight(spielfeld, x, y);

            if (counter >= 3)
            {
                spielfeldNeu[x, y].Status = true;
            }
        }
        
        public static void botRow(Cell[,] spielfeld, Cell[,] spielfeldNeu, int x,int y)
        {
            int counter = 0;
            counter += checkLeft(spielfeld, x, y);
            counter += checkTop(spielfeld, x, y);
            counter += checkTopLeft(spielfeld, x, y);
            counter += checkTopRight(spielfeld, x, y);
            counter += checkRight(spielfeld, x, y);

            if (counter >= 3)
            {
                spielfeldNeu[x, y].Status = true;
            }
        }
        
        public static void leftRow(Cell[,] spielfeld, Cell[,] spielfeldNeu, int x,int y)
        {
            int counter = 0;
            counter += checkRight(spielfeld, x, y);
            counter += checkTop(spielfeld, x, y);
            counter += checkTop(spielfeld, x, y);
            counter += checkTopRight(spielfeld, x, y);
            counter += checkRight(spielfeld, x, y);

            if (counter >= 3)
            {
                spielfeldNeu[x, y].Status = true;
            }
        }
    }
}