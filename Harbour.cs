using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class Harbour : Boat
    {
        public static int rowboats;
        public static int motorboats;
        public static int sailingboats;
        public static int cargoboats;
        public static double avaragespeed;
        public static double totalweightofdock;
        public static int freespots;
       
        public static List<Boat> WaitingToDock = new List<Boat>();
        public static Boat[] DockedBoats = new Boat[64];
        public static Boat[] secondRowBoat = new Boat[64];

      

        public static void HarbourInformation()
        {
            rowboats = 0;
            motorboats = 0;
            sailingboats = 0;
            cargoboats = 0;
            avaragespeed = 0;
            totalweightofdock = 0;
            freespots = 0;
            int counter = 0;
            foreach(var boat in Harbour.DockedBoats)
            {
               if(boat != null)
               {
                  if (boat is RowBoat)
                  {
                      
                     rowboats++;
                  }

                  else if (boat is MotorBoat)
                  {
                     motorboats++;
                  }

                    try
                    {
                      if (boat is SailingBoat && boat != Harbour.DockedBoats[counter - 1])
                      {
                            
                            sailingboats++;
                      }
                    }
                    catch
                    {
                        sailingboats++; /*Will fall to catch if Harbour.DockedBoats[counter - 1] out of range*/
                        counter++;
                        continue;
                    }

                    try
                    {
                        if (boat is CargoBoat && boat != Harbour.DockedBoats[counter - 1])
                        {
                            
                            cargoboats++;
                        }
                    }
                    catch
                    {
                        cargoboats++; /*Will fall to catch if Harbour.DockedBoats[counter - 1] out of range*/
                        counter++;
                        continue;
                    }
                     
               }

               else
               {
                    counter++;
                    continue;
               }

                counter++;
            }

            foreach(var boat in Harbour.secondRowBoat)
            {
                if(boat != null)
                {
                    rowboats++;
                }
                else
                {
                    continue;
                }
            }

            counter = 0;
            foreach (var boat in Harbour.DockedBoats)
            {
                try
                {
                    if (boat != null && boat != Harbour.DockedBoats[counter - 1])
                    {
                        totalweightofdock = totalweightofdock + boat.Weight;
                        counter++;
                    }
                    else
                    {
                        counter++;
                        continue;
                    }
                }
                catch
                {
                    counter++;
                    continue;
                }
                
            }

            foreach (var boat in Harbour.DockedBoats)
            {
                try
                {
                    if (boat != null && boat != Harbour.DockedBoats[counter - 1])
                    {
                        avaragespeed = avaragespeed + boat.MaxSpeed;
                        counter++;
                    }
                    else
                    {
                        counter++;
                        continue;
                    }
                }
                catch
                {
                    counter++;
                    continue;
                }
                
            }

            foreach(var boat in Harbour.DockedBoats)
            {
                if(boat == null)
                {
                    freespots++;
                }
                else
                {
                    continue;
                }
            }

            Console.Clear();
            Console.WriteLine("Tryck [SPACE] för ny dag eller [esc] för att avsluta.\n");
            Console.WriteLine($"Totalt antal roddbåtar: {rowboats}\nTotalt antal motorbåtar: {motorboats}\nTotalt antal segelbåtar: {sailingboats}\nTotalt antal lastfartyg: {cargoboats}\nTotal vikt av båtbeståndet i hamnen: {totalweightofdock / 1000}ton\nMedelhastighet av båtbeståndet i hamnen: {avaragespeed / rowboats + motorboats + sailingboats + cargoboats}\nAntal lediga platser i hamnen: {freespots}\nAntal avvisade båtar: {RefusedBoats.refusedBoatCounter}");
        }

    }
}
