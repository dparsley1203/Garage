using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.Name = "FXS";
            Zero fx = new Zero();
            fx.Name = "FX";
            fx.CurrentChargePercentage = 34;
            Tesla modelS = new Tesla() { Name = "ModelS" };
            Cessna mx410 = new Cessna { MainColor = "Orange", MaximumOccupancy = 5 };
            Ram truck = new Ram { MainColor = "Potato", MaximumOccupancy = 6 };

            //Another way of adding color
            // fxs.MainColor = "Blue";

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The current battery life for {ev.Name} is {ev.CurrentChargePercentage}%");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.Name}'s battery has been charged to {ev.CurrentChargePercentage}%");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();
            Alumacraft fastcraft = new Alumacraft() { propellerType = "Stubbie" };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150, truck, fastcraft
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The gas tank has {gv.CurrentTankPercentage}% left", gasVehicles);
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Gas tank has been filled to {gv.CurrentTankPercentage}$");
            }

            // First part of exercise
            // fxs.Drive();
            // fxs.Turn("left");
            // fxs.Stop();
            // modelS.Drive();
            // modelS.Turn("right");
            // modelS.Stop();
            // Console.WriteLine();
            // mx410.Drive();
            // mx410.Turn("Around");
            // mx410.Stop();
            // Console.WriteLine();
            // truck.Drive();
            // truck.Turn("a U'ie");
            // truck.Stop();


        }
    }
}
