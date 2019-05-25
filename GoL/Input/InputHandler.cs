using System;
using System.Collections.Generic;
using System.Text;

namespace GoL.Input
{
    class InputHandler
    {
        static public int Number(string message)
        {
            bool invalidInput = true;
            while (invalidInput)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int parsed))
                {
                    return parsed;
                }

                Console.Clear();
                Console.WriteLine("Ihre Eingabe muss eine Zahl sein.");
                Console.Write("Wollen sie es nochmal versuchen?(J/N)    ");
                ConsoleKeyInfo exit = Console.ReadKey();

                if (!exit.Key.Equals("Y"))
                {
                    invalidInput = false;
                }
            }
            Environment.Exit(0x0);

            return 0;
        }
    }
}
