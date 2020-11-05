using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class HarbourControl
    {
        static public void harbourControler()
        {
            for(int i = 0; i<Harbour.DockedBoats.Length; i++)
            {
                try
                {
                    if(Harbour.DockedBoats[i] == null)
                    {
                        continue;
                    }

                    if (Harbour.DockedBoats[i] != Harbour.DockedBoats[i + 1])
                    {
                        Harbour.DockedBoats[i].TimeDockedIn++;
                    }
                }
                catch
                {
                    /*The forloop checks if boat is the same as next one in collection before adding time, when the last element in collection is checked index is out of range and exection is thrown, there for the addition of time of the last boat is in catch instead of within the forloop*/
                    if(Harbour.DockedBoats[i] != null)
                    {
                        Harbour.DockedBoats[i].TimeDockedIn++;
                    }
                   
                    continue;
                }
            }

            
            foreach (var boat in Harbour.secondRowBoat)
            {
                if(boat != null)
                {
                    boat.TimeDockedIn++;
                }
               
            }

           for(int i = 0; i<Harbour.DockedBoats.Length; i++)
           {
                if(Harbour.DockedBoats[i] is RowBoat && Harbour.DockedBoats[i].TimeDockedIn > 2)
                {
                    Harbour.DockedBoats[i] = null;
                }

                if (Harbour.DockedBoats[i] is MotorBoat && Harbour.DockedBoats[i].TimeDockedIn > 4)
                {
                    Harbour.DockedBoats[i] = null;
                }

                if (Harbour.DockedBoats[i] is SailingBoat && Harbour.DockedBoats[i].TimeDockedIn > 5)
                {
                    Harbour.DockedBoats[i] = null;
                    Harbour.DockedBoats[i + 1] = null;
                }

                if (Harbour.DockedBoats[i] is CargoBoat && Harbour.DockedBoats[i].TimeDockedIn > 7)
                {
                    Harbour.DockedBoats[i] = null;
                    Harbour.DockedBoats[i + 1] = null;
                    Harbour.DockedBoats[i + 2] = null;
                    Harbour.DockedBoats[i + 3] = null;
                }

           }

           for(int i = 0; i<Harbour.secondRowBoat.Length; i++)
           {
               if(Harbour.secondRowBoat[i] != null)
               {
                    if (Harbour.secondRowBoat[i].TimeDockedIn > 2)
                    {
                        Harbour.secondRowBoat[i] = null;
                    }
               }
                

           }
        }
    }
}
