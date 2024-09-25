using System.Collections;

namespace Turbo.az;

public interface IVehicleController
{
    public void AddVehicle(IVehicle vehicle);
    public void UpdateVehicleByBrand( int index, string newValue);
    public void UpdateVehicleByModel(int index, string newValue);
    public void UpdateVehicleByMileage(int index, decimal newValue);
    public void UpdateVehicleByPrice(int index, decimal newValue);
    public void RemoveVehicle(int index);
    public void ShowVehicles();
}