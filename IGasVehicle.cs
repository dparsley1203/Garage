
namespace Garage
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }

        void RefuelTank();

        int CurrentTankPercentage { get; set; }

    }
}
