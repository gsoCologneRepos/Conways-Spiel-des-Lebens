using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GoL.Import
{
    class ImportData
    {
        public static Cell[,] Txt()
        {
            Console.Clear();
            Console.WriteLine("Bitte geben sie den Pfad für die .txt-Datei an.");
            string path = Console.ReadLine();
            List<string[]> lines = new List<string[]>();

            foreach (string line in File.ReadLines(path, Encoding.UTF8)) {
                string[] lineArray = line.Split("");
                lines.Add(lineArray);
            }

            Cell[,] cells = new Cell[lines.Count, lines.Count];

            for (var i = 0; i < lines.Count; i++)
            {
                for (var j = 0; j < lines[i].Length; j++)
                {
                    string[] line = lines[i];
                    if (line[j].Equals("X"))
                    {
                        cells[i, j].Status = true;
                    }
                    else
                    {
                        cells[i, j].Status = false;
                    }
                }
            }

            return cells;
        }
    }
}
