using System;

namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"{MainColor} Plup Plup Plup");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessena turns {direction} and goes zoooooom");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessena goes zoooooom and comes to a full stop");
        }
    }
}
