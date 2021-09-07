using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        // public void CurrentTankPercentage()
        // {

        // }

        public int CurrentTankPercentage { get; set; } = 1;

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes Buuurrrrr");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram turns {direction} and goes zoooooom");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram goes zoooooom and comes to a full stop");
        }
    }
}