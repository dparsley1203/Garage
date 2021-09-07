
namespace Garage
{
    public class Alumacraft : Vehicle, IGasVehicle, IWaterVehice
    {
        public string propellerType { get; set; }

        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public int CurrentTankPercentage { get; set; } = 60;
    }

}