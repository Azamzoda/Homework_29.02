public class Car : Transport
{

    public string FuelType { get; set; }

    public Car(string name, int capacity, int maxSpeed, string fuelType):base(name, capacity, maxSpeed)
    {
        FuelType = fuelType;
    }
}