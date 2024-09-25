using System.Collections;

namespace Turbo.az;

public class CarController : IVehicleController
{
    public void AddVehicle(IVehicle vehicle)
    {
        Cars.Add(vehicle);
    }

    public void UpdateVehicleByBrand(int index, string newValue)
    {
        foreach (Car car in Cars)
        {
            if (car.ID == index)
            {
                car.brand = newValue;
            }
        }
        ShowVehicles();
    }

    public void UpdateVehicleByModel(int index, string newValue)
    {
        foreach (Car car in Cars)
        {
            if (car.ID == index)
            {
                car.model = newValue;
            }
        }
        ShowVehicles();
    }

    public void UpdateVehicleByMileage(int index, decimal newValue)
    {
        foreach (Car car in Cars)
        {
            if (car.ID == index)
            {
                car.mileage = newValue;
            }
        }
        ShowVehicles();
    }

    public void UpdateVehicleByPrice(int index, decimal newValue)
    {
        foreach (Car car in Cars)
        {
            if (car.ID == index)
            {
                car.price = newValue;
            }
        }
        ShowVehicles();
    }

    public void RemoveVehicle(int index)
    {
        foreach (Car car in Cars)
        {
            if (index == car.ID)
            {
                Cars.RemoveAt(index-1);
                break;
            }
        }
        ShowVehicles();
    }

    public void ShowVehicles()
    {
        foreach (Car car in Cars)
        {
            Console.WriteLine("======================\n" +
                              $"PRODUCT ID: {car.ID}\n" +
                              $"Brand: {car.brand}\n" +
                              $"Model: {car.model}\n" +
                              $"Mileage: {car.mileage}\n" +
                              $"Price: {car.price}\n" +
                              $"======================");
        }
    }

    public ArrayList Cars;
    public CarController()
    {
        Cars = new ArrayList();
    }
    
}