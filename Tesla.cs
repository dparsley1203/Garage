using System;

namespace Garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }



        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The Tesla has a color of {MainColor} and goes schzzzzz");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla turns {direction} and goes zoooooom");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla goes zoooooom and comes to a full stop");
        }
    }
}