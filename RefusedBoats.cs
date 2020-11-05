using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Version_1
{
    class RefusedBoats
    {
        public static int refusedBoatCounter = 0;
        static public void Refusedboats()
        {
            var refusedBoats = Harbour.WaitingToDock.Except(Harbour.DockedBoats).ToList(); /*Checks which boats did not get added to DockedBoats and makes new list of them*/
            var allRefusedBoats = refusedBoats.Except(Harbour.secondRowBoat).ToList(); /*Checks the new list of refusedboats against the 2nd rowboat collection also*/

            if (allRefusedBoats.Count > 0)
            {
                foreach (var boat in allRefusedBoats)
                {
                    Console.WriteLine($"Hamnen är full och båt {boat.IdentityString} är därav avisad.");
                    refusedBoatCounter++;
                }

                Console.WriteLine($"Totalt avvisade båtar: {refusedBoatCounter}\n");
                refusedBoats.Clear();
                allRefusedBoats.Clear();
                Console.WriteLine("Tryck [ENTER] för att fortsätta...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Alla båtar fick plats i hamnen.\n");
                refusedBoats.Clear();
                allRefusedBoats.Clear();
                Console.WriteLine("Tryck [ENTER] för att fortsätta...");
                Console.ReadLine();
            }

        }
    }
}
