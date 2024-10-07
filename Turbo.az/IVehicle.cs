namespace Turbo.az;

public interface IVehicle
{
    public int ID { get; set; }
    public string brand { get; set; }
    public string model { get; set; }
    public decimal mileage{ get; set; }
    public decimal price { get; set; }
    public int User_ID { get; set; }
    
}