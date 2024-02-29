class CargoPlane : Airplane
{
    public int CargoCapacity { get; set; }

    public CargoPlane(string name, int capacity, int maxSpeed, double wingspan, int cargoCapacity):base(name, capacity, maxSpeed, wingspan)
    {
        CargoCapacity = cargoCapacity;
    }
}