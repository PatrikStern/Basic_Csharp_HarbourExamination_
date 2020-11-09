using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Version_1
{
    class Harbour : Boat
    {
        public static List<Boat> WaitingToDock = new List<Boat>();
        public static Boat[] DockedBoats = new Boat[64];
        public static Boat[] secondRowBoat = new Boat[64];

      

        public static void HarbourInformation()
        {
            /*Since different kind of boats take up different amount of elements we need to "clean out" the duppletes from the array to not be counted mulitple times in statistics, this is down below.*/

            var cleanedHarbourList = Harbour.DockedBoats.
                GroupBy(boats => boats?.IdentityString).
                Select(acctualsingleboat => acctualsingleboat?.FirstOrDefault());

            var HarbourlistSecondRowBoat = Harbour.secondRowBoat.
                GroupBy(boats => boats?.IdentityString).
                Select(acctualsingleboat => acctualsingleboat?.FirstOrDefault());

            var CleanedSpectrumOfBoats = Harbour.DockedBoats.Union(secondRowBoat).ToList(); 


            /*We can then use the cleaned list for our statistic needs with only one object of the actual boat per element."*/


            var rowboat = CleanedSpectrumOfBoats.
                Count(Boats => Boats?.IdentityString.StartsWith("R-") ?? false);

            var motorboat = CleanedSpectrumOfBoats.
                Count(Boats => Boats?.IdentityString.StartsWith("M-") ?? false);

            var sailingboat = CleanedSpectrumOfBoats.
                Count(Boats => Boats?.IdentityString.StartsWith("S-") ?? false);

            var cargoboat = CleanedSpectrumOfBoats.
                Count(Boats => Boats?.IdentityString.StartsWith("L-") ?? false);

            var totalWeight = CleanedSpectrumOfBoats.
                Sum(boats => boats?.Weight);

            var averagespeed = CleanedSpectrumOfBoats.
                Average(Boats => Boats?.MaxSpeed);

            var freespots = Harbour.DockedBoats.
                Count(boats => boats?.Equals(null) ?? true);


            Console.Clear();
            Console.WriteLine("Tryck [SPACE] för ny dag eller [esc] för att avsluta.\n");
            Console.WriteLine($"Totalt antal roddbåtar: {rowboat}\nTotalt antal motorbåtar: {motorboat}\nTotalt antal segelbåtar: {sailingboat}\nTotalt antal lastfartyg: {cargoboat}\nTotal vikt av båtbeståndet i hamnen: {totalWeight / 1000}ton\nMedelhastighet av båtbeståndet i hamnen: {averagespeed}\nAntal lediga platser i hamnen: {freespots}\nAntal avvisade båtar: {RefusedBoats.refusedBoatCounter}");
        }

    }
}
