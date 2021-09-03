using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }


        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero and goes zoooooom");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero turns {direction} and goes zoooooom");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero and goes zoooooom and comes to a full stop");
            Console.WriteLine();
        }
    }
}