using System.Collections;

namespace Turbo.az;

public class MotoController
{
    public void AddVehicle(IVehicle vehicle)
    {
        Motos.Add(vehicle);
    }

    public void UpdateVehicleByBrand(int index, string newValue)
    {
        foreach (Moto moto in Motos)
        {
            if (moto.ID == index)
            {
                moto.brand = newValue;
            }
        }
        ShowVehicles();
    }

    public void UpdateVehicleByModel(int index, string newValue)
    {
        foreach (Moto moto in Motos)
        {
            if (moto.ID == index)
            {
                moto.model = newValue;
            }
        }
        ShowVehicles();
    }

    public void UpdateVehicleByMileage(int index, decimal newValue)
    {
        foreach (Moto moto in Motos)
        {
            if (moto.ID == index)
            {
                moto.mileage = newValue;
            }
        }
        ShowVehicles();
    }

    public void UpdateVehicleByPrice(int index, decimal newValue)
    {
        foreach (Moto moto in Motos)
        {
            if (moto.ID == index)
            {
                moto.price = newValue;
            }
        }
        ShowVehicles();
    }

    public void RemoveVehicle(int index)
    {
        foreach (Moto moto in Motos)
        {
            if (index == moto.ID)
            {
                Motos.RemoveAt(index-1);
                break;
            }
        }
        ShowVehicles();
    }

    public void ShowVehicles()
    {
        foreach (Moto moto in Motos)
        {
            Console.WriteLine("======================\n" +
                              $"PRODUCT ID: {moto.ID}\n" +
                              $"Brand: {moto.brand}\n" +
                              $"Model: {moto.model}\n" +
                              $"Mileage: {moto.mileage}\n" +
                              $"Price: {moto.price}\n" +
                              $"======================");
        }
    }

    public ArrayList Motos;

    public MotoController()
    {
        Motos = new ArrayList();
    }
}