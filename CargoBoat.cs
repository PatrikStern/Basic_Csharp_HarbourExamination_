using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class CargoBoat :Boat
    {
        static int containers;
        static string name = "Lastfartyg";
        public int AmountOfContainers { get; set; }
        public string Name { get; set; }

        public CargoBoat()
        {
            IdentityString = Boat.IdentityGiver("L");
            Weight = Boat.WeightCalc(3000, 20000);
            MaxSpeed = Boat.MaxSpeedCalc(0, 20);
            TimeDockedIn = Boat.TimeDockedCalc(1);
            ContainerCreator();
            AmountOfContainers = containers;
            Name = name;
        }

        private static int ContainerCreator()
        {
            Random random = new Random();
            int rnd = random.Next(0, 500);
            containers = rnd;
            return containers;
        }
    }
}
