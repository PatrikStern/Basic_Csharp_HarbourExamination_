using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class Sea
    {
        static public void CreateSea()
        {
            Alphabet.alfabetmaker(); //Initalizes an alphabet for our identifier for each boat. 

            for (int i = 0; i < 500; i++) //Generates a "sea" with an amount of boats in it, which are placed in the list of boats.
            {
                RowBoat boat = new RowBoat();
                Boat.boats.Add(boat);
                MotorBoat motorBoat = new MotorBoat();
                Boat.boats.Add(motorBoat);
                SailingBoat sailingBoat = new SailingBoat();
                Boat.boats.Add(sailingBoat);
                CargoBoat cargoBoat = new CargoBoat();
                Boat.boats.Add(cargoBoat);
            }
        }

        static public void BoatsArriving()
        {
            int inPut = 0;
            try
            {
                Console.WriteLine("Hur många båtar vill lägga till i hamnen?: Ange ett helttal och tryck [ENTER].");
                inPut = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("Ange ett gilitigt helttal...");
                BoatsArriving();
            }

            for (int i = 0; i < inPut; i++) //Generates random boats out of different posistions of the boats list which are the boats that will "arrive" to the dock for each itteration.
            {
                Boat boat;
                Random random = new Random();
                int rnd = random.Next(0, Boat.boats.Count);
                boat = Boat.boats[rnd];
                var existing = Harbour.WaitingToDock.Exists(exists => exists?.Equals(boat) ?? false); /*Makes shure not same boat are added multiple times*/
                if (existing == false)
                {
                    Harbour.WaitingToDock.Add(boat);
                }
                else if (existing == true)
                {
                    continue;
                }
            }
        }
        
    }
}
