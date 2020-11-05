using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;


namespace Version_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool day = true;
            Console.WriteLine("Tryck [SPACE] för ny dag eller [esc] för att avsluta.");
            Console.WriteLine();
            while (day)
            {
                Harbour.WaitingToDock.Clear();
                Harbour.boats.Clear();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                ConsoleKey key = consoleKeyInfo.Key;
                switch (key)  
                {
                    case ConsoleKey.Spacebar:
                        Console.Clear();
                        Sea.CreateSea();
                        Sea.BoatsArriving();
                        HarbourControl.harbourControler();
                        Fillharbour.FillHarbour();
                        RefusedBoats.Refusedboats();
                        Console.Clear();
                        PrintOutHarbour.WriteDock();
                        break;
                    case ConsoleKey.Escape:
                        day = false;
                        break;
                    case ConsoleKey.I:
                        Harbour.HarbourInformation();
                        break;
                    default:
                         Console.WriteLine("Tryck [SPACE] för ny dag eller [esc] för att avsluta.");
                        break;
                } 
            }
        }
    }
}
