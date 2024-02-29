class PassengerCar : Car
{
    public int PassengerCapacity { get; set; }

    public PassengerCar(string name, int capacity, int maxSpeed, string fuelType, int passengerCapacity):base(name, capacity, maxSpeed, fuelType)
    {
        PassengerCapacity = passengerCapacity;
    }
}