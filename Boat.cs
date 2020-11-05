using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class Boat
    {
        static string alfabetOut;
        static string Identity;
        static int weight;
        static double speed;
        static int DockTime;

        public static List<Boat> boats = new List<Boat>(); 

        public string IdentityString { get; set; }
        public int Weight { get; set; }
        public double MaxSpeed { get; set; }
        public int TimeDockedIn { get; set; }

        public static string IdentityGiver(string i) //Inparameter to be able to shift first identify letter for each shipsort when calling method in different class. 
        {            
            alfabetOut = "";
            Identity = i + "-"; 
            for (int loop = 0; loop < 3; loop++)
            {
                Random random = new Random();
                int rnd = random.Next(0, 26);
                alfabetOut = Alphabet.alfabet[rnd]; //Takes out random position out of alphabet collection created in 'Organs' and places string in alphabetOut.
                Identity = Identity + alfabetOut; //Adds the collected alphabetic string to return string value Identity.
            }
            return Identity;
        }

        public static int WeightCalc(int i, int j)
        {
            Random random = new Random();
            int rnd = random.Next(i, j);
            weight = rnd;
            return weight;
        }

        public static double MaxSpeedCalc(int i, int j) //From knot to Km.
        {
            Random random = new Random();
            double rnd = random.Next(i, j);
            speed = rnd * 1.852; //The randomised number rnd is a variabel containing the speed in knot, this formula multiplies it to turn it into km/h and place that in output value.
            return Math.Round(speed, 0, MidpointRounding.ToEven); //Rounds of decimal value to nearast integral with 0 decimal numbers. 
        }

        public static int TimeDockedCalc(int i)
        {
            DockTime = i;
            return DockTime;
        }

    }
}
