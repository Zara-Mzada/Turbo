using System.Collections;

namespace Turbo.az;

public class TruckController
{
    public void AddVehicle(IVehicle vehicle)
    {
        Trucks.Add(vehicle);
    }

    public void UpdateVehicleByBrand(int index, string newValue)
    {
        foreach (Truck truck in Trucks)
        {
            if (truck.ID == index)
            {
                truck.brand = newValue;
            }
        }
        ShowVehicles();
    }

    public void UpdateVehicleByModel(int index, string newValue)
    {
        foreach (Truck truck in Trucks)
        {
            if (truck.ID == index)
            {
                truck.model = newValue;
            }
        }
        ShowVehicles();
    }

    public void UpdateVehicleByMileage(int index, decimal newValue)
    {
        foreach (Truck truck in Trucks)
        {
            if (truck.ID == index)
            {
                truck.mileage = newValue;
            }
        }
        ShowVehicles();
    }

    public void UpdateVehicleByPrice(int index, decimal newValue)
    {
        foreach (Truck truck in Trucks)
        {
            if (truck.ID == index)
            {
                truck.price = newValue;
            }
        }
        ShowVehicles();
    }

    public void RemoveVehicle(int index)
    {
        foreach (Truck truck in Trucks)
        {
            if (index == truck.ID)
            {
                Trucks.RemoveAt(index-1);
                break;
            }
        }
        ShowVehicles();
    }

    public void ShowVehicles()
    {
        foreach (Truck truck in Trucks)
        {
            Console.WriteLine("======================\n" +
                              $"PRODUCT ID: {truck.ID}\n" +
                              $"Brand: {truck.brand}\n" +
                              $"Model: {truck.model}\n" +
                              $"Mileage: {truck.mileage}\n" +
                              $"Price: {truck.price}\n" +
                              $"======================");
        }
    }

    public ArrayList Trucks;
    public TruckController()
    {
        Trucks = new ArrayList();
    }
}