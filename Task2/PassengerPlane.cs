class PassengerPlane : Airplane
{
    public int PassengerCapacity { get; set; }

    public PassengerPlane(string name, int capacity, int maxSpeed, double wingspan, int passengerCapacity):base(name, capacity, maxSpeed, wingspan)
    {
        PassengerCapacity = passengerCapacity;
    }
}