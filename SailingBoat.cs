using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class SailingBoat : Boat
    {
        static int lenght;
        static string name = "Segelbåt";
        public int Lenght { get; set; }
        public string Name { get; set; }

        public SailingBoat()
        {
            IdentityString = Boat.IdentityGiver("S");
            Weight = Boat.WeightCalc(800, 6000);
            MaxSpeed = Boat.MaxSpeedCalc(0, 12);
            TimeDockedIn = Boat.TimeDockedCalc(1);
            LenghtCreator();
            Lenght = lenght;
            Name = name;

        }

        private int LenghtCreator()
        {
            Random random = new Random();
            int rnd = random.Next(10, 61);
            lenght = rnd;
            return lenght;
        }
    }
}
