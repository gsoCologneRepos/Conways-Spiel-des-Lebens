using System.Threading.Tasks.Dataflow;

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
            for(int i=0;i<spielfeld.GetLength(0);i++)
            {
                for(int j=0;j<spielfeld.GetLength(0);j++)
                {
                    spielfeld[i, j] = new Cell(false);
                }
                
            }
            return spielfeld;
        }

    }
}