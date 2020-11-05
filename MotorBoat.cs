using System;
using System.Collections.Generic;
using System.Text;

namespace Version_1
{
    class MotorBoat : Boat
    {
        static int horsepower;
        static string name = "Motorbåt";
        public int HorsePower { get; set; }
        public string Name { get; set; }

        public MotorBoat()
        {
            IdentityString = Boat.IdentityGiver("M");
            Weight = Boat.WeightCalc(200, 3000);
            MaxSpeed = Boat.MaxSpeedCalc(0, 60);
            TimeDockedIn = Boat.TimeDockedCalc(1); //Days in harbour.
            HorsePowerCreator();
            HorsePower = horsepower;
            Name = name;
        }

        private int HorsePowerCreator()
        {
            Random random = new Random();
            int rnd = random.Next(10, 1001);
            horsepower = rnd;
            return horsepower;
        }
    }
}
