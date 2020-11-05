using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class RowBoat : Boat
    {
        static int Passengers;
        static string name = "Roddbåt";
        public int MaxOfPassengers { get; set; }
        public string Name { get; set; }

        public RowBoat()
        {
            
           IdentityString = Boat.IdentityGiver("R");
           Weight = Boat.WeightCalc(100, 300); //Kg.
           MaxSpeed = Boat.MaxSpeedCalc(0, 3 + 1); //0 up to 3 knot.
           TimeDockedIn = Boat.TimeDockedCalc(1); //Stays in harbor for one day before depature.

            PassengerCount();
            MaxOfPassengers = Passengers;
            Name = name;
        }

        public static int PassengerCount()
        {
            Random random = new Random();
            int rnd = random.Next(1, 6 + 1); //Returns a passengercount of 1 - 6 ppl.
            Passengers = rnd;
            return Passengers;
        }
        
    }


}
