using System;


public interface IElectricVehicle
{
    double BatteryKWh { get; set; }

    string Name { get; set; }

    void ChargeBattery();

    // void CurrentChargePercentage();

    int CurrentChargePercentage { get; set; }
}
