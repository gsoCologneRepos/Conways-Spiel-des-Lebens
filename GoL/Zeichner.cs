using System;
namespace GoL
{
    public static class Zeichner
    {
        public static void Zeichnen(Cell[,] spielfeld, int round)
        {
            Console.WriteLine("Runde: "+round);
            for (int i = 0; i < spielfeld.GetLength(0); i++)
            {
                for (int j = 0; j < spielfeld.GetLength(0); j++)
                {
                    spielfeld.GetLength(0);
                    
                    if (spielfeld[i, j].Status == false && j != spielfeld.GetLength(0) - 1)
                    {
                        Console.Write("0");
                    }
                    
                    //wenn tot und ende der Zeile
                    else if (spielfeld[i, j].Status == false && j == spielfeld.GetLength(0) - 1)
                    {
                        Console.Write("0 \n");
                    }
                    else if(spielfeld[i, j].Status == true && j != spielfeld.GetLength(0) - 1)
                    {
                        Console.Write("X");
                    }
                    
                    //wenn lebendig und ende der zeile
                    else if(spielfeld[i, j].Status == true && j == spielfeld.GetLength(0) - 1)
                    {
                        Console.Write("X \n");
                    }
                }
            }
        }
    }
}