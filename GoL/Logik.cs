namespace GoL
{
    public static class Logik
    {
        public static void topLeftCorner(Cell[,] spielfeld, Cell[,] spielfeldNeu)
        {
            if(spielfeld[0,1].Status==true && spielfeld[1,1].Status==true && spielfeld[1,0].Status==true)
            {
                spielfeldNeu[0, 0].Status = true;
            }
            else
            {
                spielfeldNeu[0, 0].Status = false;
            }
        }

        public static void botLeftCorner(Cell[,] spielfeld, Cell[,] spielfeldNeu, int x)
        {
            if(spielfeld[x,1].Status==true && spielfeld[x-1,1].Status==true && spielfeld[x-1,0].Status==true)
            {
                spielfeldNeu[x, x].Status = true;
            }
            else
            {
                spielfeldNeu[x, x].Status = false;
            }
        }
    }
}