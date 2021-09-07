using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double BatteryKWh { get; set; } = 200.00;

        public string Name { get; set; }


        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            // method definition omitted
        }

        // public void CurrentChargePercentage()
        // {

        // }

        public int CurrentChargePercentage { get; set; } = 78;




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