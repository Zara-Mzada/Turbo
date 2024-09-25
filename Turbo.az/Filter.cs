using System.Collections;

namespace Turbo.az;

public static class Filter
{
    public static void SearchByBrand(ArrayList vehicles, string brand)
    {
        foreach (IVehicle vehicle in vehicles)
        {
            if (vehicle.brand == brand)
            {
                Console.WriteLine("=============================\n" +
                                  $"PRODUCT ID: {vehicle.ID}\n" +
                                  $"Brand: {vehicle.brand}\n" +
                                  $"Model: {vehicle.model}\n" +
                                  $"Price: {vehicle.price}\n" +
                                  $"Mileage: {vehicle.mileage}\n" +
                                  $"=============================");
            }
        }
    }

    public static void SearchByModel(ArrayList vehicles, string model)
    {
        foreach (IVehicle vehicle in vehicles)
        {
            if (vehicle.model == model)
            {
                Console.WriteLine("=============================\n" +
                                  $"PRODUCT ID: {vehicle.ID}\n" +
                                  $"Brand: {vehicle.brand}\n" +
                                  $"Model: {vehicle.model}\n" +
                                  $"Price: {vehicle.price}\n" +
                                  $"Mileage: {vehicle.mileage}\n" +
                                  $"=============================");
            }
        }
    }
    
    public static void SearchByPrice(ArrayList vehicles, decimal min, decimal max)
    {
        foreach (IVehicle vehicle in vehicles)
        {
            if (vehicle.price>=min && vehicle.price<=max)
            {
                Console.WriteLine("=============================\n" +
                                  $"PRODUCT ID: {vehicle.ID}\n" +
                                  $"Brand: {vehicle.brand}\n" +
                                  $"Model: {vehicle.model}\n" +
                                  $"Price: {vehicle.price}\n" +
                                  $"Mileage: {vehicle.mileage}\n" +
                                  $"=============================");
            }
        }
    }
    
    public static void SearchByMileage(ArrayList vehicles, decimal min, decimal max)
    {
        foreach (IVehicle vehicle in vehicles)
        {
            if (vehicle.mileage>=min && vehicle.mileage<=max)
            {
                Console.WriteLine("=============================\n" +
                                  $"PRODUCT ID: {vehicle.ID}\n" +
                                  $"Brand: {vehicle.brand}\n" +
                                  $"Model: {vehicle.model}\n" +
                                  $"Price: {vehicle.price}\n" +
                                  $"Mileage: {vehicle.mileage}\n" +
                                  $"=============================");
            }
        }
    }
}