using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class Fillharbour
    {
        public static void FillHarbour()
        {

            foreach (Boat boat in Harbour.WaitingToDock)
            {
                var firstEmptyElement = Array.FindIndex(Harbour.DockedBoats, empty => empty?.Equals(null) ?? true); /*Finds first empty element, if non returns -1*/
                var lastEmptyElement = Array.FindLastIndex(Harbour.DockedBoats, empty => empty?.Equals(null) ?? true); /*Finds last empty element, if non returns -1*/
                var rowBoatLocater = Array.FindLastIndex(Harbour.DockedBoats, rowboat => rowboat?.IdentityString.StartsWith("R-") ?? false);/*Finds the last rowboat in []*/
                var rowItemExists = Array.Exists(Harbour.DockedBoats, exists => exists?.IdentityString.StartsWith("R-") ?? false);/*Gives back bool if rowboat exists*/
                var sailingItemExists = Array.Exists(Harbour.DockedBoats, exists => exists?.IdentityString.StartsWith("S-") ?? false);/*Gives back bool if sailingboat exists*/
                var cargoItemExists = Array.Exists(Harbour.DockedBoats, exists => exists?.IdentityString.StartsWith("L-") ?? false);/*Gives back bool if cargoboat exists*/

                if (boat is RowBoat)
                {
                    if (rowItemExists == false && firstEmptyElement > -1)
                    {
                        Harbour.DockedBoats[firstEmptyElement] = boat;
                    }

                    else if (rowItemExists == true)
                    {
                        if (Harbour.secondRowBoat[rowBoatLocater] == null)
                        {
                            Harbour.secondRowBoat[rowBoatLocater] = boat;
                        }

                        else if (firstEmptyElement > -1)
                        {
                            Harbour.DockedBoats[firstEmptyElement] = boat;
                        }

                    }
                }

                if (boat is MotorBoat)
                {
                    if (firstEmptyElement > -1)
                    {
                        Harbour.DockedBoats[firstEmptyElement] = boat;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (boat is SailingBoat) /*Algoritm checks if their is enough space for the sailing boat (2x[]) within the range of first or last empty idex in array*/
                {

                    //if (sailingItemExists == false)
                    //{
                    try
                    {
                        if (firstEmptyElement > -1 && Harbour.DockedBoats[firstEmptyElement] == null && Harbour.DockedBoats[firstEmptyElement + 1] == null)
                        {
                            Harbour.DockedBoats[firstEmptyElement] = boat;
                            Harbour.DockedBoats[firstEmptyElement + 1] = boat;
                        }
                        else if (firstEmptyElement > -1 && Harbour.DockedBoats[lastEmptyElement] == null && Harbour.DockedBoats[lastEmptyElement - 1] == null)
                        {
                            Harbour.DockedBoats[lastEmptyElement] = boat;
                            Harbour.DockedBoats[lastEmptyElement - 1] = boat;
                        }
                    }


                    catch
                    {
                        continue;
                    }

                    
                }
                   
               
                if (boat is CargoBoat) /*Algoritm checks if their is enough space for the cargo boat (4x[]) within the range of first or last empty idex in array*/
                {

                    try
                    {
                        if (firstEmptyElement > -1 && Harbour.DockedBoats[firstEmptyElement] == null && Harbour.DockedBoats[firstEmptyElement + 1] == null && Harbour.DockedBoats[firstEmptyElement + 3] == null)
                        {
                            Harbour.DockedBoats[firstEmptyElement] = boat;
                            Harbour.DockedBoats[firstEmptyElement + 1] = boat;
                            Harbour.DockedBoats[firstEmptyElement + 2] = boat;
                            Harbour.DockedBoats[firstEmptyElement + 3] = boat;
                        }
                        else if (firstEmptyElement > -1 && Harbour.DockedBoats[lastEmptyElement] == null && Harbour.DockedBoats[lastEmptyElement - 3] == null)
                        {
                            Harbour.DockedBoats[lastEmptyElement] = boat;
                            Harbour.DockedBoats[lastEmptyElement - 1] = boat;
                            Harbour.DockedBoats[lastEmptyElement - 2] = boat;
                            Harbour.DockedBoats[lastEmptyElement - 3] = boat;

                        }
                    }
                    catch
                    {
                        continue;
                    }
                    
                 
                }
            }
        }
    }
}
