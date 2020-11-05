using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class PrintOutHarbour
    {
        
        public static void WriteDock()
        {
            Console.WriteLine("Tryck [SPACE] för ny dag, [i] för hamn info eller [esc] för att avsluta.\n");
            for (int i = 0; i<Harbour.DockedBoats.Length; i++)
            {
                if (Harbour.DockedBoats[i] is RowBoat)
                {
                    Console.WriteLine((i + 1) + " " + ((RowBoat)Harbour.DockedBoats[i]).Name + " " + Harbour.DockedBoats[i].IdentityString + " " + Harbour.DockedBoats[i].Weight + " " + Harbour.DockedBoats[i].MaxSpeed + "km" + " " + "Max antal passagerare:" + ((RowBoat)Harbour.DockedBoats[i]).MaxOfPassengers + " " + "Dag: " + Harbour.DockedBoats[i].TimeDockedIn);
                    if(Harbour.secondRowBoat[i] != null)
                    {
                        Console.WriteLine((i + 1) + " " + ((RowBoat)Harbour.secondRowBoat[i]).Name + " " + Harbour.secondRowBoat[i].IdentityString + " " + Harbour.secondRowBoat[i].Weight + " " + Harbour.secondRowBoat[i].MaxSpeed + "km" + " " + "Max antal passagerare:" + ((RowBoat)Harbour.secondRowBoat[i]).MaxOfPassengers + " " + "Dag: " + Harbour.secondRowBoat[i].TimeDockedIn);
                    }
                }

                else if(Harbour.DockedBoats[i] is MotorBoat)
                {
                    Console.WriteLine((i + 1) + " " + ((MotorBoat)Harbour.DockedBoats[i]).Name + " " + Harbour.DockedBoats[i].IdentityString + " " + Harbour.DockedBoats[i].Weight + " " + Harbour.DockedBoats[i].MaxSpeed + "km" + " " + ((MotorBoat)Harbour.DockedBoats[i]).HorsePower + "hk" + " " + "Dag: " + Harbour.DockedBoats[i].TimeDockedIn);
                }

                else if (Harbour.DockedBoats[i] is SailingBoat)
                {
                    if(i == 0)
                    {
                        Console.WriteLine((i + 1) + "-" + (i + 2) + " " + ((SailingBoat)Harbour.DockedBoats[i]).Name + " " + Harbour.DockedBoats[i].IdentityString + " " + Harbour.DockedBoats[i].Weight + " " + Harbour.DockedBoats[i].MaxSpeed + "km" + " " + ((SailingBoat)Harbour.DockedBoats[i]).Lenght + "m" + " " + "Dag: " + Harbour.DockedBoats[i].TimeDockedIn);
                    }
                    else if (Harbour.DockedBoats[i] == Harbour.DockedBoats[i - 1])
                    {
                      continue;
                    }
                    else
                    {
                        Console.WriteLine((i + 1) + "-" + (i + 2) + " " + ((SailingBoat)Harbour.DockedBoats[i]).Name + " " + Harbour.DockedBoats[i].IdentityString + " " + Harbour.DockedBoats[i].Weight + " " + Harbour.DockedBoats[i].MaxSpeed + "km" + " " + ((SailingBoat)Harbour.DockedBoats[i]).Lenght + "m" + " " + "Dag: " + Harbour.DockedBoats[i].TimeDockedIn);
                    }
                   
                }

                else if (Harbour.DockedBoats[i] is CargoBoat)
                {
                    if (i == 0)
                    {
                        Console.WriteLine((i + 1) + "-" + (i + 4) + " " + ((CargoBoat)Harbour.DockedBoats[i]).Name + " " + Harbour.DockedBoats[i].IdentityString + " " + Harbour.DockedBoats[i].Weight + " " + Harbour.DockedBoats[i].MaxSpeed + "km" + " " + "Containers: " + ((CargoBoat)Harbour.DockedBoats[i]).AmountOfContainers + " " + "Dag: " + Harbour.DockedBoats[i].TimeDockedIn);
                    }
                    else if (Harbour.DockedBoats[i] == Harbour.DockedBoats[i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine((i + 1) + "-" + (i + 4) + " " + ((CargoBoat)Harbour.DockedBoats[i]).Name + " " + Harbour.DockedBoats[i].IdentityString + " " + Harbour.DockedBoats[i].Weight + " " + Harbour.DockedBoats[i].MaxSpeed + "km" + " " + "Containers: " + ((CargoBoat)Harbour.DockedBoats[i]).AmountOfContainers + " " + "Dag: " + Harbour.DockedBoats[i].TimeDockedIn); 
                    }

                }


                else
                {
                    Console.WriteLine((i+1) + "");
                }
            }
            
            
        }
    }
}
            