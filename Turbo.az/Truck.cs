namespace Turbo.az;

public class Truck : IVehicle
{
    public int ID { get; set; }
    public string brand { get; set; }
    public string model { get; set; }
    public decimal mileage { get; set; }
    public decimal price { get; set; }
    public int User_ID { get; set; }
    private static int _truckCount = 0;
    public Truck(string brand, string model, decimal mileage, decimal price) :  base()
    {
        _truckCount++;
        ID = _truckCount;
        this.model = model;
        this.brand = brand;
        this.mileage = mileage;
        this.price = price;
    }
}